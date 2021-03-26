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

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            timer1_Tick(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = new DateTime();
            time = DateTime.Now;
            Hour.Text = time.Hour.ToString();
            Minute.Text = time.Minute.ToString();
            Second.Text = time.Second.ToString();
            if (time.ToLongTimeString().Equals(selected.ToLongTimeString()))
            {
                MessageBox.Show("Перевод пк в режим сна");
                Thread.Sleep(1000);
                hibernate();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = DateTime.Parse($"{SetHour.Value}:{SetMinute.Value}:{SetSec.Value}");
            MessageBox.Show("Время выбрано");
            Console.WriteLine(selected.ToShortTimeString());
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
                notifyIcon1.ShowBalloonTip(5);
            }
        }
    }
}
