using Mobile_shop_application;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mobile_shop_application
{
    public partial class SplashForm : Form
    {
        Timer fadeInTimer = new Timer();
        Timer waitTimer = new Timer();

        public SplashForm()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(16, 12, 8);

            Label title = new Label
            {
                Text = "Wellcome to Mobile Shop Management 😊 System 😊 ",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            this.Controls.Add(title);

            fadeInTimer.Interval = 50;
            fadeInTimer.Tick += FadeInTimer_Tick;
            fadeInTimer.Start();

            waitTimer.Interval = 3000; // Stay for 3 seconds
            waitTimer.Tick += WaitTimer_Tick;
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
                this.Opacity += 0.05;
            else
            {
                fadeInTimer.Stop();
                waitTimer.Start();
            }
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            waitTimer.Stop();
            this.Hide();
       //     Main_form main = new Main_form(); // Your main form
           // main.ShowDialog();

        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
