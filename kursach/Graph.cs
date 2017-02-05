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
    public partial class Graph : UserControl
    {
        const int bufferSize = 1000;
        Timer secondTimer;
        int[] values;
        int tempOffsetValue;
        int maxOffsetValue = 50;

        int highLabelValue = 5000;
        int highMediumLabelValue = 1000;
        int lowMediumLabelValue = 100;
        int lowLabelValue = 0;



        DateTime lastTimerTick;
        Dictionary<KeyValuePair<int,int>,Label> timelineLabels;
        public Graph()
        {
            InitializeComponent();
            timelineLabels = new Dictionary<KeyValuePair<int,int>,Label>();
            values = new int[bufferSize + maxOffsetValue+1];
            for (int i = 0; i < bufferSize + maxOffsetValue+1; i++)
            {
                values[i] = -1;
            }
            OnFixedUpdate(null, null);
           
            
            
            tempOffsetValue = 0;
        }
        public void SetGraphTimer(Timer t)
        {
            secondTimer = t;
            secondTimer.Tick += new EventHandler(OnFixedUpdate);
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Brush goodPing = new SolidBrush(Color.FromArgb(192, 255, 192));
            Brush averagePing = new SolidBrush(Color.FromArgb(255, 255, 192));
            Brush badPing = new SolidBrush(Color.FromArgb(255,192,192));
            e.Graphics.FillRectangle(goodPing, 0, pictureBox1.Height / 3*2, pictureBox1.Width, pictureBox1.Height / 3);
            e.Graphics.FillRectangle(averagePing, 0, pictureBox1.Height / 3, pictureBox1.Width, pictureBox1.Height / 3);
            e.Graphics.FillRectangle(badPing, 0, 0, pictureBox1.Width, pictureBox1.Height / 3);
            // черточки
            Brush blackBrush = new SolidBrush(Color.Black);
            e.Graphics.FillRectangle(blackBrush, 0, -1, 4, 2);
            e.Graphics.FillRectangle(blackBrush, 0, pictureBox1.Height/3-1, 4, 2);
            e.Graphics.FillRectangle(blackBrush, 0, pictureBox1.Height/3*2-1, 4, 2);
            Brush redBrush = new SolidBrush(Color.Red);
            Brush blueBrush = new SolidBrush(Color.DarkOrchid);
            int startValuePos = bufferSize + tempOffsetValue - pictureBox1.Width;
            int endValuePos = bufferSize + tempOffsetValue;
            for (int i = 0; i < pictureBox1.Width; i++)
            {
                if (values[startValuePos + i] == -1)
                    continue;
                if (values[startValuePos + i] == -2)
                    e.Graphics.FillRectangle(redBrush, i, 0, 1, pictureBox1.Height);
                if (values[startValuePos + i] < lowMediumLabelValue)
                {
                    int heightCol = (int)((1.0f * pictureBox1.Height / 3) * (1.0f * (values[startValuePos + i]- lowLabelValue)/ (lowMediumLabelValue-lowLabelValue)));
                    e.Graphics.FillRectangle(blueBrush, i, pictureBox1.Height - heightCol, 1, heightCol);
                }
                else if (values[startValuePos + i] < highMediumLabelValue)
                {
                    int heightCol = (int)(1.0f * pictureBox1.Height / 3) + (int)((1.0f * pictureBox1.Height / 3) * (1.0f * (values[startValuePos + i] - lowMediumLabelValue) / (highMediumLabelValue- lowMediumLabelValue)));
                    e.Graphics.FillRectangle(blueBrush, i, pictureBox1.Height - heightCol, 1, heightCol);
                }
                else if (values[startValuePos + i] <= highLabelValue)
                {
                    int heightCol = (int)(2.0f * pictureBox1.Height / 3) + (int)((1.0f * pictureBox1.Height / 3) * (1.0f * (values[startValuePos + i] - highMediumLabelValue) / (highLabelValue-highMediumLabelValue)));
                    e.Graphics.FillRectangle(blueBrush, i, pictureBox1.Height - heightCol, 1, heightCol);
                }
            }






        }
        private void timeLabelPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), 60 / 2 - 1, 0, 2, 2);
        }
        private void OnFixedUpdate(object sender, EventArgs args)
        {
            int numberOfMinutesShown = pictureBox1.Width / 60 +2;
            int i = 0;
            DateTime currentTime = DateTime.Now;
            DateTime tempTime = DateTime.Now;
            tempTime = tempTime.AddMilliseconds(-tempTime.Millisecond);
            lastTimerTick = tempTime;
            tempTime = tempTime.AddSeconds(-tempTime.Second);
            
            for (; i < numberOfMinutesShown; )
            {
                Label timeLabel;
                if (timelineLabels.TryGetValue(new KeyValuePair<int,int>(tempTime.Hour,tempTime.Minute),out timeLabel))
                {
                    TimeSpan diffTime = currentTime - tempTime;
                    timeLabel.Location = new Point(TimelinePanel.Width - ((int)diffTime.TotalSeconds + 30), 0);
                }
                else
                {
                    timeLabel = new Label();
                    timeLabel.AutoSize = false;
                    timeLabel.Width = 60;
                    timeLabel.Height = 14;
                    timeLabel.TextAlign = ContentAlignment.TopCenter;
                    TimelinePanel.Controls.Add(timeLabel);
                    timelineLabels.Add(new KeyValuePair<int,int>(tempTime.Hour,tempTime.Minute),timeLabel);
                    TimeSpan diffTime = currentTime - tempTime;
                    timeLabel.Location = new Point(TimelinePanel.Width - ((int)diffTime.TotalSeconds  + 30), 0);
                    timeLabel.Text = tempTime.ToShortTimeString();
                    timeLabel.Paint += new PaintEventHandler(timeLabelPaint);
                }
                tempTime = tempTime.AddMinutes(-1.0f);
                i++;
            }
            int hourNow = currentTime.Hour;
            int minutesNow = currentTime.Minute;
            List<KeyValuePair<int,int>> keysToDelete = new List<KeyValuePair<int,int>>(); 
            foreach (var pair in timelineLabels)
            {
                int minutesDiff = (hourNow - pair.Key.Key) * 60 + (minutesNow - pair.Key.Value);
                if (minutesDiff < 0 || minutesDiff > numberOfMinutesShown)
                {
                    keysToDelete.Add(pair.Key);
                    pair.Value.Text = "";
                    TimelinePanel.Controls.Remove(pair.Value);
                    pair.Value.Dispose();
                }
            }
            foreach(var key in keysToDelete)
            {
                timelineLabels.Remove(key);
            }
            if (tempOffsetValue < maxOffsetValue)
            {
                tempOffsetValue++;
                values[bufferSize + tempOffsetValue] = -1;
            }
            else
            {
                for (int j = 0; j < bufferSize; j++)
                {
                    values[j] = values[j + maxOffsetValue];
                }
                tempOffsetValue = 0;
            }
            pictureBox1.Invalidate();
        }
        public void SetValue(DateTime when, int value)
        {
            TimeSpan timeElapsed = lastTimerTick - when;
            int valueOffset = -(int)timeElapsed.TotalSeconds;
            if (valueOffset > 0)
            {
                return;
            }
                
            values[bufferSize + tempOffsetValue + valueOffset] = value;
        }
        public void SetHighLabelText(string text,int value)
        {
            HighLabel.Text = text;
            highLabelValue = value;
        }
        public void SetHighMediumLabelText(string text, int value)
        {
            HighMediumLabel.Text = text;
            highMediumLabelValue = value;
        }
        public void SetLowMediumLabelText(string text, int value)
        {
            LowMediumLabel.Text = text;
            lowMediumLabelValue = value;
        }
        public void SetLowLabelText(string text, int value)
        {
            LowLabel.Text = text;
            lowLabelValue = value;
        }
        public int[] GetValues()
        {
            int[] temp = new int[bufferSize];
            Array.Copy(values,temp,1000);
            return temp;
        }
    }
}
