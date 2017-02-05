using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursach
{
    public partial class CollapsiblePanel : UserControl
    {
        public EventHandler changedHeight;
        public bool collapsed = true;
        int min;
        int max;
        double avg;
        int count;
        public CollapsiblePanel()
        {
            InitializeComponent();
            min = 5001;
            max = -1;
            avg = -1;
            count = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (collapsed == false)
            {
                button1.Text = "+";
                this.Height = 22;
                collapsed = true;
            }
            else
            {
                button1.Text = "-";
                this.Height = 105;
                collapsed = false;
            }
            changedHeight(this, EventArgs.Empty);
        }


        public void SetName(string name)
        {
            label1.Text = name;
        }
        public void SetValue(DateTime when, int value)
        {
            if (value != -2)
            {
                if (value < min)
                {
                    min = value;
                    MinLabel.Text = "Min " + min.ToString() + "ms";
                }
                if (value > max)
                {
                    max = value;
                    MaxLabel.Text = "Max " + max.ToString() + "ms";
                }
                if (count == 0)
                {
                    avg = value;
                    AvgLabel.Text = "Avg " + value.ToString() + "ms";
                    count = 1;
                }
                else
                {
                    avg = avg * (1.0f * count / (1.0f * count + 1)) + 1.0f * value / (1.0f * count + 1);
                    int iAvg = (int)avg;
                    AvgLabel.Text = "Avg " + iAvg.ToString() + "ms";
                }
            }
            graph1.SetValue(when, value);
        }
        public void SetTimer(Timer t1s)
        {
            graph1.SetGraphTimer(t1s);
        }
        public int[] GetData()
        {
            int[] temp = new int[3];
            temp[0] = min;
            temp[1] = max;
            temp[2] = (int)avg;
            return temp;
        }
    }
}
