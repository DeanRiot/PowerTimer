using System;
using System.Drawing;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;

namespace Sleeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            fontCollection.AddFontFile("Resources/font.ttf");
            FontFamily family = fontCollection.Families[0];
            Font font = new Font(family, 22);
            Hour.Font = font;
            Minute.Font = font;
            Second.Font = font;
            Dots1.Font = font;
            Dots2.Font = font;
        }

        DateTime selected = new DateTime();
        DateTime time = new DateTime();
        bool selectedFlag = false;
        bool showed = false;

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1_Tick(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            time = DateTime.Now;
            Hour.Text = time.Hour.ToString();
            Minute.Text = time.Minute.ToString();
            Second.Text = time.Second.ToString();
            
            if (selectedFlag)
            {
                var popupTime = selected.Subtract(new TimeSpan(0, 15, 0));
                if (time.ToLongTimeString().Equals(popupTime.ToLongTimeString()) && !showed)
                {
                    notifyIcon1.BalloonTipText = $"Компьютер выключится через 15 минут";
                    if (notifyIcon1.Visible)
                        notifyIcon1.ShowBalloonTip(5);
                    else
                    {
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(5);
                        notifyIcon1.Visible = false;
                    }
                    showed = true;
                }

                if (time.ToLongTimeString().Equals(selected.ToLongTimeString()))
                {
                    MessageBox.Show("Перевод пк в режим сна через 1 минуту");
                    Thread.Sleep(60000);
                    showed = false;
                    hibernate();
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!selectedFlag)
            {
                selected = DateTime.Parse($"{SetHour.Value}:{SetMinute.Value}:{SetSec.Value}");
                MessageBox.Show("Время выбрано");
                Console.WriteLine(selected.ToShortTimeString());
                selectedFlag = true;
                showed = false;
                setTime.Text = "Отключить";
            }
            else
            {
                showed = false;
                selectedFlag = false;
                setTime.Text = "Задать";
            }
        }
        
        private void hibernate()
        {
            bool isHibernate = Application.SetSuspendState(PowerState.Suspend, false, false);
            if (isHibernate == false)
                MessageBox.Show("Could not suspend the system.");
        }
        
        private void SetNow_Click(object sender, EventArgs e)
        {
            hibernate();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            { 
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Sleeper работает в трее";
                notifyIcon1.ShowBalloonTip(5);
            }
        }
    }
}
