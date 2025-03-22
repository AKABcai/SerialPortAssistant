using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 串口助手
{
    public partial class Form1 : Form
    {
        //串口开关判断
        private bool isOpen = false;

        //是否接收显示(用于实现暂停按钮)
        private bool isRxShow = true;

        //设置接收缓存区
        private List<byte> receiveBuffer = new List<byte>();

        //设置发送缓存区 
        private List<byte> sendBuffer = new List<byte>();

        //接收计数
        private int receiveCount = 0;

        //发送计数
        private int sendCount = 0;

        //队列
        private Queue<byte> bufferQueue = null;

        //帧头标志位 用于判断数据帧头是否已经到达
        private bool isHeadReceive = false;

        //记录帧数据长度
        private int frameLenth = 0;

        public Form1()
        {
            InitializeComponent();

            //取消跨线程的安全检测
            //由于串口接收事件是跨线程的，会有安全问题
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //以代码方式添加COM口
            //this.port.Items.Add("COM4");
            //this.port.Items.Add("COM5");

            ////COM口的默认选值,初始化
            //this.port.SelectedIndex = 2;

            //this.baud.SelectedIndex = 1;

            //this.check.SelectedIndex = 0;

            //this.data.SelectedIndex = 3;

            //this.stop.SelectedIndex = 0;

            //给发送框添加预设文本
            //this.Send.Text = "我是发送框";

            //给接收框添加预设文本
            //this.Receive.Text = "我是接收框";

            serialLoad();

            //将队列实例化
            bufferQueue = new Queue<byte>();
        }

        //加载串口并初始化，让程序扫描并添加电脑中的串口到下拉列表中
        private void serialLoad()
        {
            //使用注册列表获取电脑中的串口
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");
            //获取注册列表里面的串口值
            string[] sSubKeys = keyCom.GetValueNames();
            //把缓存的值清掉，相当于刷新
            port.Items.Clear();
            foreach (var sValue in sSubKeys)
            {
                //读取出来的就是串口名
                string portName = (string)keyCom.GetValue(sValue);
                port.Items.Add(portName);
            }


            //COM口的默认选值,初始化
            this.port.SelectedIndex = 0;

            this.baud.SelectedIndex = 1;

            this.check.SelectedIndex = 0;

            this.data.SelectedIndex = 3;

            this.stop.SelectedIndex = 0;
        }

        //数据的发送
        private void sendData()
        {
            serialPort1.Write(sendBuffer.ToArray(), 0, sendBuffer.Count);
            sendCount += sendBuffer.Count;
            sendcount.Text = sendCount.ToString();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            //如果发送的数据不为空，则接收
            if (this.Send.Text != "" && serialPort1.IsOpen)
            {
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
            else
            {
                MessageBox.Show("请先输入发送数据");
            }
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //先判断串口是否打开，如果没有，那么设置串口各个参数
                if (serialPort1.IsOpen == false)
                {
                    //端口号
                    serialPort1.PortName = port.Text;
                    //波特率(类型为数值，要强转)
                    serialPort1.BaudRate = Convert.ToInt32(baud.Text);
                    //数据位
                    serialPort1.DataBits = Convert.ToInt32(data.Text);
                    //校验位
                    switch (check.SelectedIndex)
                    {
                        //none(无校验) odd(基校验)  even(偶校验)
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            serialPort1.Parity = Parity.None;
                            break;
                    }
                    //停止位
                    switch (stop.SelectedIndex)
                    {
                        case 0:
                            serialPort1.StopBits = StopBits.One;
                            break;
                        case 1:
                            serialPort1.StopBits = StopBits.OnePointFive;
                            break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two;
                            break;
                        default:
                            serialPort1.StopBits = StopBits.One;
                            break;
                    }

                    serialPort1.Open();
                    isOpen = true;
                    open_btn.Text = "关闭串口";
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    open_btn.Text = "打开串口";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }

        }

        //串口数据的接收
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (isRxShow == false)
                return;

            //读取串口数据
            //1.需要读取有效数据BytesToRead
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(dataTemp, 0, dataTemp.Length);

            //存缓存区
            receiveBuffer.AddRange(dataTemp);

            //记录长度，用于更新状态栏的接收计数
            receiveCount += dataTemp.Length;

            this.Invoke(new EventHandler(delegate
            {
                //状态栏显示接收数据的长度
                receivecount.Text = receiveCount.ToString();

                //数据帧接收是否启用
                if (startData.Checked == false)
                {
                    if (!rehex.Checked)
                    {
                        //2.编码格式的选择
                        string str = Encoding.GetEncoding("gb2312").GetString(dataTemp);
                        //3.0x00 -> \0 结束 不会显示
                        str = str.Replace("\0", "\\0");

                        Receive.AppendText(str);
                    }
                    else
                    {
                        //十六进制选中的状态下
                        Receive.AppendText(Transform.ToHexString(dataTemp, " "));
                    }
                }
                //解析数据 使用queue(队列)
                else
                {
                    //把数据添加到队列
                    foreach (byte item in dataTemp)
                    {
                        bufferQueue.Enqueue(item);
                    }

                    //解析获取帧头
                    if (isHeadReceive == false)
                    {
                        foreach (byte item in bufferQueue.ToArray())
                        {
                            if (item != 0x7f)
                            {
                                //出列
                                bufferQueue.Dequeue();
                                Console.WriteLine("not 0x7f Dequeue");
                            }
                            else
                            {
                                //获取头部数据
                                isHeadReceive = true;
                                Console.WriteLine("0x7f is received");
                                break;
                            }
                        }
                    }

                    if (isHeadReceive == true)
                    {
                        //判断有数据帧长度
                        if (bufferQueue.Count >= 2)
                        {
                            Console.WriteLine(DateTime.Now.ToString());
                            Console.WriteLine($"show the data in bufferQueue{Transform.ToHexString(bufferQueue.ToArray())}");
                            //输出的是帧长度，[0]是帧头0x7f，所以取[1]
                            Console.WriteLine($"frame lenth = {String.Format("{0:X2}", bufferQueue.ToArray()[1])}");
                            frameLenth = bufferQueue.ToArray()[1];

                            //处理帧数据             (帧头  数据长度  数据  校验方式)
                            //一帧完整的数据长度判断,不代表数据正确
                            if (bufferQueue.Count >= 1 + 1 + frameLenth + 2)
                            {
                                byte[] frameBuffer = new byte[1 + 1 + frameLenth + 2];
                                //把有效的帧长数据拷贝到缓存区里
                                Array.Copy(bufferQueue.ToArray(), 0, frameBuffer, 0, frameBuffer.Length);
                                //进行校验(crc)
                                if (crc_check(frameBuffer))
                                {
                                    Console.WriteLine("frame is check ok.pick it");
                                    data_txb.Text = Transform.ToHexString(frameBuffer);
                                    //数据
                                    data1_txb.Text = String.Format("{0:X2}", frameBuffer[2]);
                                    data2_txb.Text = String.Format("{0:X2}", frameBuffer[3]);
                                    data3_txb.Text = String.Format("{0:X2}", frameBuffer[4]);
                                    data4_txb.Text = String.Format("{0:X2}", frameBuffer[5]);
                                }
                                else
                                {
                                    //无效数据
                                    Console.WriteLine("bad frame,drop");

                                }

                                //不管数据是否有效，都要从缓存里取出来
                                for (int i = 0; i < 1 + 1 + frameLenth + 2; i++)
                                {
                                    bufferQueue.Dequeue();
                                }

                                isHeadReceive = false;
                            }
                        }
                        //继续接收数据(长度不对也继续接收)
                    }
                }
            }));
            //string dataReceive = serialPort1.ReadExisting();
            //Receive.AppendText(dataReceive);
        }

        //CRC解析帧，考虑大小端
        private bool crc_check(byte[] frameBuffer)
        {
            bool ret = false;

            //这里是crc校验，校验的是crc前面的数据，所以减去帧校验方式的两个长度
            //先获取crc前面的数据
            byte[] temp = new byte[frameBuffer.Length - 2];
            //将数据缓存进来
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            
            //这里的校验是把数据传进去得到校验数据，再比对原来那个数据帧的校验数据
            byte[] crcdata = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);
            if (crcdata[0] == frameBuffer[frameBuffer.Length - 2]&&
                crcdata[1] == frameBuffer[frameBuffer.Length - 1])
            {
                ret = true;
                return ret;
            }
            return ret;
        }

        //接收是否显示
        private void stop_btn_Click(object sender, EventArgs e)
        {
            if (isRxShow == true)
            {
                isRxShow = false;
                stop_btn.Text = "取消暂停";
            }
            else
            {
                isRxShow = true;
                stop_btn.Text = "暂停";
            }
        }

        //切换接收数据的显示
        private void rehex_CheckedChanged(object sender, EventArgs e)
        {
            if (Receive.Text == "") return;
            if (rehex.Checked)
            {
                //让接收的数据以16进制显示
                Receive.Text = Transform.ToHexString(receiveBuffer.ToArray(), " ");
            }
            else
            {
                //让接收的数据以原来的编码显示
                Receive.Text = Encoding.GetEncoding("gb2312").GetString(receiveBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            receiveBuffer.Clear();
            Receive.Text = "";
            receivecount.Text = "0";
            receiveCount = 0;
        }

        //是否启用自动清空
        private void autoclear_CheckedChanged(object sender, EventArgs e)
        {

            if (autoclear.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }

        //自动清空的执行
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Receive.Text.Length >= 4096)
            {
                receiveBuffer.Clear();
                Receive.Text = "";
                receivecount.Text = "0";
                receiveCount = 0;
            }
        }

        //当焦点不在发送框时,对发送的内容做缓存处理
        private void Send_Leave(object sender, EventArgs e)
        {
            //判断当勾选了十六进制时，数据格式是否正确
            if (sehex.CheckState == CheckState.Checked)
            {
                if (DataEncoding.IsHexString(Send.Text.Replace(" ", "")))
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(Send.Text.Replace(" ", "")));
                }
                else
                {
                    MessageBox.Show("请输入正确的十六进制数据!");
                    Send.Select();
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(Send.Text));
            }
        }

        private void Send_TextChanged(object sender, EventArgs e)
        {
            //十六进制切换 会出现问题 这问题就是0x00 转换
        }

        private void sehex_CheckedChanged(object sender, EventArgs e)
        {
            if (Send.Text == "") return;

            if (sehex.Checked == true)
            {
                Send.Text = Transform.ToHexString(sendBuffer.ToArray(), " ");
            }
            else
            {
                Send.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0", "\\0");
            }
        }

        //清空发送
        private void sendclear_btn_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();
            Send.Text = "";
            sendCount = 0;
            sendcount.Text = "0";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
