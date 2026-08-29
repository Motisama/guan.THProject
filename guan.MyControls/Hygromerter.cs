using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guan.MyControls
{
    public partial class Hygromerter : UserControl
    {
        public Hygromerter()
        {
            InitializeComponent();
        }

        //实际湿度显示
        private int barHeight = 360;

        public double SetHeightValue
        {
            set
            {
                if (value > 100 || value < 0)
                {
                    MessageBox.Show("湿度值必须在0%至100%之间！", "信息提示");
                }
                else
                {
                    double realValue = (barHeight / 100.0) * value;
                    //上面空白部分的遮罩高度
                    this.lbBar.Height = barHeight - Convert.ToInt32(realValue);
                }
            }
        }
    }
}
