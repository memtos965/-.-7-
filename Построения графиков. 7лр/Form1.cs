using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Построения_графиков._7лр
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xBegin = Convert.ToInt32(numericUpDown1.Value),xEnd= Convert.ToInt32(numericUpDown2.Value),xStep= Convert.ToInt32(numericUpDown3.Value),y;
            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            double x = xBegin;
            if(xBegin>xEnd)
            {
                xStep *= -1;
            }
            while (x<=xEnd)
            {
                y = x + 10;
                this.chart1.Series[0].Points.AddXY(x, y);//Ошибка в индексации
                x += xStep;
            }
            x = xBegin;
            while (x <= xEnd)
            {
                y = Math.Sin(x);
                chart1.Series[1].Points.AddXY(x,y);
                x += xStep;
            }
            x = xBegin;
            while (x <= xEnd)
            {
                y = x*x+x*1+1;
                chart1.Series[2].Points.AddXY(x,y);
                x += xStep;
            }
        }
        public bool flag1 = false, flag2 = false, flag3 = false;
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!flag1)
            { chart1.Series[0].Enabled = true;flag1 = true; }
            else
            { chart1.Series[0].Enabled = false; flag1 = false; }
            if (flag1 || flag2 || flag3)
            { chart1.Legends[0].Enabled = true; }
            else
            { chart1.Legends[0].Enabled = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!flag2)
            { chart1.Series[1].Enabled = true; flag2 = true; }
            else
            { chart1.Series[1].Enabled = false; flag2 = false; }
            if (flag1 || flag2 || flag3)
            { chart1.Legends[0].Enabled = true; }
            else
            { chart1.Legends[0].Enabled = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (!flag3)
            { chart1.Series[2].Enabled = true; flag3 = true; }
            else
            { chart1.Series[2].Enabled = false; flag3 = false; }
            if (flag1 || flag2 || flag3)
            { chart1.Legends[0].Enabled = true; }
            else
            { chart1.Legends[0].Enabled = false; }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToInt32(trackBar1.Value);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = Convert.ToInt32(trackBar2.Value);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            numericUpDown3.Value = Convert.ToInt32(trackBar3.Value);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            trackBar2.Value = Convert.ToInt32(numericUpDown2.Value);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            trackBar3.Value = Convert.ToInt32(numericUpDown3.Value);
        }
    }
}
