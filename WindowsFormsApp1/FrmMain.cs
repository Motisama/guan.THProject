using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using guan.MoubusRTULib;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        //创建通信类对象
        ModbusRTU modbusRTU = new ModbusRTU();

        public FrmMain()
        {
            InitializeComponent();
            initialize();
        }

        /// <summary>
        /// 初始化方法
        /// </summary>
        private void initialize()
        {
            //电脑当前可用的端口号
            this.cbb_PortName.DataSource = SerialPort.GetPortNames();

            //绑定波特率下拉列表
            string[] allBaudRate = new string[]
                {
                "2400",
                "4800",
                "9600",
                "19200",
                "38400",
                "57600",
                "115200"
                };
            this.cbb_BaudRate.Items.AddRange(allBaudRate);
            this.cbb_BaudRate.SelectedIndex = 2;

            //定时器循环时间
            this.timer_Read.Interval = 1000;
        }

        //连接标志位
        private bool _isConnected = false;
        /// <summary>
        /// 根据连接状态执行操作
        /// </summary>
        public bool IsConnected
        {
            get { return _isConnected; }
            set
            {
                _isConnected = value;//保存当前状态
                if (_isConnected)
                {
                    this.btn_OpenAndClose.Text = "断 开 连 接";
                    this.btn_OpenAndClose.BackColor = Color.Firebrick;

                    this.lbl_Status.ForeColor = Color.Green;
                }
                else
                {
                    this.btn_OpenAndClose.Text = "打 开 连 接";
                    this.btn_OpenAndClose.BackColor = Color.Green;

                    this.lbl_Status.ForeColor = Color.Silver;
                }
            }
        }

        /// <summary>
        /// 打开或关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenAndClose_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                modbusRTU = new ModbusRTU();
                try
                {
                    //打开连接
                    modbusRTU.Connect(this.cbb_PortName.Text, Convert.ToInt32(this.cbb_BaudRate.Text));
                    IsConnected = true;
                    this.timer_Read.Start();//启动循环

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.timer_Read.Stop();//先停定时器防止报错成堆
                    modbusRTU.DisConnect();//出现异常时关闭串口
                    IsConnected = false;
                }
            }
            else
            {
                this.timer_Read.Stop();//先停定时器防止报错成堆
                modbusRTU.DisConnect();
                IsConnected = false;
            }
        }

        /// <summary>
        /// 定时循环读取寄存器数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Read_Tick(object sender, EventArgs e)
        {
            if (IsConnected)
            {
                try
                {
                    //读取文本框内容并获取数据
                    int registerLength = Convert.ToInt32(this.txt_Count.Text.Trim());
                    byte[] dataBytes = modbusRTU.ReadHoldingRegister(Convert.ToInt32(this.nud_SlaveID.Value),
                        Convert.ToInt32(this.txt_StartAddress.Text.Trim()), registerLength);

                    //解析并显示数据
                    if (dataBytes != null && dataBytes.Length == registerLength * 2)
                    {
                        short sTemperatureValue = (short)(dataBytes[0] << 8 | dataBytes[1]);
                        double temperatureValue = sTemperatureValue * 0.1;

                        short sHumidityValue = (short)(dataBytes[2] << 8 | dataBytes[3]);
                        double humidityValue = sHumidityValue * 0.1;

                        //给控件、文本框赋值
                        this.thmeter1.SetHeightValue = humidityValue;
                        this.hygromerter1.SetHeightValue = temperatureValue;
                        this.lbl_Tm.Text = Convert.ToString(humidityValue);
                        this.lbl_Hm.Text = Convert.ToString(temperatureValue);
                    }
                    else
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 窗体关闭前执行的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer_Read.Stop();//关闭循环
        }
    }
}
