using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guan.MyControls
{
    public partial class Thmeter : UserControl
    {
        public Thmeter()
        {
            InitializeComponent();
        }

        //设置温湿度柱状显示和实际温度显示
        private int barHeight = 360;

        public double SetHeightValue
        {
            set
            {
                if (value > 80 || value < -40)
                {
                    MessageBox.Show("温度值必须在-40至80之间！", "信息提示");
                }
                else
                {
                    double realValue = barHeight / 120.0 * (value+40);
                    //上面空白部分的遮罩高度
                    this.lbBar.Height=barHeight - Convert.ToInt32(realValue);
                }
            }
        }

    }
}
