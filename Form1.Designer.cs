
namespace Sleeper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SetHour = new System.Windows.Forms.NumericUpDown();
            this.SetMinute = new System.Windows.Forms.NumericUpDown();
            this.SetSec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SetNow = new System.Windows.Forms.Button();
            this.setTime = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Dots2 = new System.Windows.Forms.Label();
            this.Dots1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Minute = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Hour = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SetHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetSec)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetHour
            // 
            this.SetHour.Location = new System.Drawing.Point(41, 70);
            this.SetHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.SetHour.Name = "SetHour";
            this.SetHour.Size = new System.Drawing.Size(33, 20);
            this.SetHour.TabIndex = 0;
            // 
            // SetMinute
            // 
            this.SetMinute.Location = new System.Drawing.Point(80, 70);
            this.SetMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SetMinute.Name = "SetMinute";
            this.SetMinute.Size = new System.Drawing.Size(33, 20);
            this.SetMinute.TabIndex = 1;
            // 
            // SetSec
            // 
            this.SetSec.Location = new System.Drawing.Point(119, 70);
            this.SetSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.SetSec.Name = "SetSec";
            this.SetSec.Size = new System.Drawing.Size(33, 20);
            this.SetSec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Время выключения";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SetNow);
            this.panel1.Controls.Add(this.setTime);
            this.panel1.Controls.Add(this.SetHour);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SetMinute);
            this.panel1.Controls.Add(this.SetSec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 155);
            this.panel1.TabIndex = 4;
            // 
            // SetNow
            // 
            this.SetNow.Location = new System.Drawing.Point(38, 125);
            this.SetNow.Name = "SetNow";
            this.SetNow.Size = new System.Drawing.Size(114, 23);
            this.SetNow.TabIndex = 5;
            this.SetNow.Text = "Сейчас";
            this.SetNow.UseVisualStyleBackColor = true;
            this.SetNow.Click += new System.EventHandler(this.SetNow_Click);
            // 
            // setTime
            // 
            this.setTime.Location = new System.Drawing.Point(38, 96);
            this.setTime.Name = "setTime";
            this.setTime.Size = new System.Drawing.Size(114, 23);
            this.setTime.TabIndex = 4;
            this.setTime.Text = "Задать";
            this.setTime.UseVisualStyleBackColor = true;
            this.setTime.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(194, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 155);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Dots2);
            this.panel3.Controls.Add(this.Dots1);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(11, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 100);
            this.panel3.TabIndex = 0;
            // 
            // Dots2
            // 
            this.Dots2.AutoSize = true;
            this.Dots2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dots2.Location = new System.Drawing.Point(131, 34);
            this.Dots2.Name = "Dots2";
            this.Dots2.Size = new System.Drawing.Size(23, 36);
            this.Dots2.TabIndex = 4;
            this.Dots2.Text = ":";
            // 
            // Dots1
            // 
            this.Dots1.AutoSize = true;
            this.Dots1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dots1.Location = new System.Drawing.Point(59, 33);
            this.Dots1.Name = "Dots1";
            this.Dots1.Size = new System.Drawing.Size(23, 36);
            this.Dots1.TabIndex = 3;
            this.Dots1.Text = ":";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Second);
            this.panel6.Location = new System.Drawing.Point(155, 37);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(46, 32);
            this.panel6.TabIndex = 2;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Second.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second.Location = new System.Drawing.Point(0, 0);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(44, 31);
            this.Second.TabIndex = 1;
            this.Second.Text = "00";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Minute);
            this.panel5.Location = new System.Drawing.Point(82, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(46, 32);
            this.panel5.TabIndex = 1;
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minute.Location = new System.Drawing.Point(0, 0);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(44, 31);
            this.Minute.TabIndex = 1;
            this.Minute.Text = "00";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Hour);
            this.panel4.Location = new System.Drawing.Point(12, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(46, 32);
            this.panel4.TabIndex = 0;
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hour.Location = new System.Drawing.Point(0, 0);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(44, 31);
            this.Hour.TabIndex = 0;
            this.Hour.Text = "00";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Sleeper работает в трее";
            this.notifyIcon1.BalloonTipTitle = "Подсказка";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sleeper работает в трее";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 155);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PowerTimer";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SetHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SetSec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SetHour;
        private System.Windows.Forms.NumericUpDown SetMinute;
        private System.Windows.Forms.NumericUpDown SetSec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button setTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Dots2;
        private System.Windows.Forms.Label Dots1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Button SetNow;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

