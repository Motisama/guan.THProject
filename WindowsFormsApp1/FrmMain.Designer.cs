namespace WindowsFormsApp1
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Tm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Hm = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_PortName = new System.Windows.Forms.ComboBox();
            this.nud_SlaveID = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_BaudRate = new System.Windows.Forms.ComboBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_OpenAndClose = new System.Windows.Forms.Button();
            this.hygromerter1 = new guan.MyControls.Hygromerter();
            this.thmeter1 = new guan.MyControls.Thmeter();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_StartAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.timer_Read = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlaveID)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(42, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "温度";
            // 
            // lbl_Tm
            // 
            this.lbl_Tm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Tm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Tm.ForeColor = System.Drawing.Color.Tomato;
            this.lbl_Tm.Location = new System.Drawing.Point(35, 536);
            this.lbl_Tm.Name = "lbl_Tm";
            this.lbl_Tm.Size = new System.Drawing.Size(77, 46);
            this.lbl_Tm.TabIndex = 2;
            this.lbl_Tm.Text = "33.6";
            this.lbl_Tm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(118, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "℃";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(282, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "湿度";
            // 
            // lbl_Hm
            // 
            this.lbl_Hm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_Hm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Hm.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_Hm.Location = new System.Drawing.Point(275, 536);
            this.lbl_Hm.Name = "lbl_Hm";
            this.lbl_Hm.Size = new System.Drawing.Size(77, 46);
            this.lbl_Hm.TabIndex = 2;
            this.lbl_Hm.Text = "33.6";
            this.lbl_Hm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(358, 536);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 46);
            this.label6.TabIndex = 2;
            this.label6.Text = "%";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Count);
            this.groupBox1.Controls.Add(this.txt_StartAddress);
            this.groupBox1.Controls.Add(this.btn_OpenAndClose);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nud_SlaveID);
            this.groupBox1.Controls.Add(this.cbb_BaudRate);
            this.groupBox1.Controls.Add(this.cbb_PortName);
            this.groupBox1.Location = new System.Drawing.Point(440, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 545);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设备连接";
            // 
            // cbb_PortName
            // 
            this.cbb_PortName.FormattingEnabled = true;
            this.cbb_PortName.Location = new System.Drawing.Point(247, 56);
            this.cbb_PortName.Name = "cbb_PortName";
            this.cbb_PortName.Size = new System.Drawing.Size(217, 32);
            this.cbb_PortName.TabIndex = 0;
            // 
            // nud_SlaveID
            // 
            this.nud_SlaveID.Location = new System.Drawing.Point(247, 176);
            this.nud_SlaveID.Name = "nud_SlaveID";
            this.nud_SlaveID.Size = new System.Drawing.Size(217, 35);
            this.nud_SlaveID.TabIndex = 1;
            this.nud_SlaveID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "串口号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "波特率：";
            // 
            // cbb_BaudRate
            // 
            this.cbb_BaudRate.FormattingEnabled = true;
            this.cbb_BaudRate.Location = new System.Drawing.Point(247, 116);
            this.cbb_BaudRate.Name = "cbb_BaudRate";
            this.cbb_BaudRate.Size = new System.Drawing.Size(217, 32);
            this.cbb_BaudRate.TabIndex = 0;
            // 
            // lbl_Status
            // 
            this.lbl_Status.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Status.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Status.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Status.Location = new System.Drawing.Point(135, 352);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(80, 97);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "·";
            this.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OpenAndClose
            // 
            this.btn_OpenAndClose.AutoSize = true;
            this.btn_OpenAndClose.BackColor = System.Drawing.Color.Green;
            this.btn_OpenAndClose.FlatAppearance.BorderSize = 0;
            this.btn_OpenAndClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OpenAndClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OpenAndClose.Location = new System.Drawing.Point(245, 390);
            this.btn_OpenAndClose.Name = "btn_OpenAndClose";
            this.btn_OpenAndClose.Size = new System.Drawing.Size(183, 63);
            this.btn_OpenAndClose.TabIndex = 3;
            this.btn_OpenAndClose.Text = "打 开 连 接";
            this.btn_OpenAndClose.UseVisualStyleBackColor = false;
            this.btn_OpenAndClose.Click += new System.EventHandler(this.btn_OpenAndClose_Click);
            // 
            // hygromerter1
            // 
            this.hygromerter1.Location = new System.Drawing.Point(281, 37);
            this.hygromerter1.Name = "hygromerter1";
            this.hygromerter1.Size = new System.Drawing.Size(153, 430);
            this.hygromerter1.TabIndex = 1;
            // 
            // thmeter1
            // 
            this.thmeter1.Location = new System.Drawing.Point(42, 37);
            this.thmeter1.Name = "thmeter1";
            this.thmeter1.Size = new System.Drawing.Size(153, 430);
            this.thmeter1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "寄存器起始地址：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "从站地址：";
            // 
            // txt_StartAddress
            // 
            this.txt_StartAddress.Location = new System.Drawing.Point(247, 233);
            this.txt_StartAddress.Name = "txt_StartAddress";
            this.txt_StartAddress.Size = new System.Drawing.Size(217, 35);
            this.txt_StartAddress.TabIndex = 6;
            this.txt_StartAddress.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 296);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "寄存器数量：";
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(245, 295);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(217, 35);
            this.txt_Count.TabIndex = 6;
            this.txt_Count.Text = "2";
            // 
            // timer_Read
            // 
            this.timer_Read.Tick += new System.EventHandler(this.timer_Read_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Hm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Tm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hygromerter1);
            this.Controls.Add(this.thmeter1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "【管】-基于Modbus通信03H实现温湿度实时采集案例";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SlaveID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private guan.MyControls.Thmeter thmeter1;
        private guan.MyControls.Hygromerter hygromerter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Tm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Hm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_PortName;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_SlaveID;
        private System.Windows.Forms.ComboBox cbb_BaudRate;
        private System.Windows.Forms.Button btn_OpenAndClose;
        private System.Windows.Forms.TextBox txt_StartAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.Timer timer_Read;
    }
}

