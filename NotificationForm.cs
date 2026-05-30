using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_planner
{
    public partial class NotificationForm : Form
    {
        private int x, y;
        private readonly int targetY;
        private readonly int startY;
        private const int AnimationSpeed = 2;
        private Timer slideDownTimer;
        public NotificationForm(string type,string message)
        {
            InitializeComponent();

            label1.Text = type;
            label2.Text = message;

            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            x = screen.Width - this.Width - 10;
            startY = screen.Height;
            targetY = screen.Height - this.Height -40;

            this.Location = new Point(x, startY);

            timer1.Interval = 20;
            timer2.Interval = 2000;
            slideDownTimer = new Timer();
            slideDownTimer.Interval = 20;
            slideDownTimer.Tick += timer3_Tick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            position();
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            slideDownTimer.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            y += AnimationSpeed;
            this.Location = new Point(x, y);

            if(y>= startY)
            {
                slideDownTimer.Stop();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (y > targetY)
            {
                y -= AnimationSpeed;
                this.Location = new Point(x, y);

            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void position()
        {
            Rectangle rectangle = Screen.PrimaryScreen.WorkingArea;
            x = rectangle.Width - this.Width - 10;
            y = rectangle.Height;

            this.Location = new Point(x, y);
        }
    }
}
