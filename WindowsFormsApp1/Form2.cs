using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private int VelocityMs { get; set; }
        private int AngleDeg { get; set; }

        private int MinYPos { get; set; }

        private PointF[] BirdTrajectory { get; set; }
        private int currentIndex = 0;
        private bool visualizationCompleted = false;

        public Form2(int velocityMS, int angleDeg)
        {
            InitializeComponent();
            this.VelocityMs = velocityMS;
            this.AngleDeg = angleDeg;
            this.BirdTrajectory = new Bird(velocityMS, angleDeg).Fly();
            MinYPos = BirdPicture.Bottom;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SpeedLabel.Text += VelocityMs;
            AngleLabel.Text += AngleDeg;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (visualizationCompleted)
                return;

            BirdPicture.Top = MinYPos - BirdPicture.Height - (int)Math.Ceiling(BirdTrajectory[currentIndex].Y);
            BirdPicture.Left = (int)Math.Ceiling(BirdTrajectory[currentIndex].X);

            if (BirdCollidingEnemy())
            {
                this.Controls.Remove(BirdPicture);
                this.Controls.Remove(PigPicture);
                visualizationCompleted = true;
                VisualizationCompleteActions();
            }

            if (currentIndex < BirdTrajectory.Length - 1)
                currentIndex += 1;
            else
            {
                visualizationCompleted = true;
                VisualizationCompleteActions();
            }
        }

        public bool BirdCollidingEnemy()
        {
            var birdCenterX = BirdPicture.Left + BirdPicture.Width / 2 + this.Left;
            var birdCenterY = BirdPicture.Top + BirdPicture.Height / 2 + this.Top;

            var pigCenterX = PigPicture.Left + PigPicture.Width / 2 + this.Left;
            var pigCenterY = PigPicture.Top + PigPicture.Height / 2 + this.Top;
            return Math.Sqrt(Math.Pow(birdCenterX - pigCenterX, 2) + Math.Pow(birdCenterY - pigCenterY, 2)) < 100;
        }

        private void VisualizationCompleteActions()
        {
            DialogResult result = MessageBox.Show("Визуализация завершена,\n хотите повторить?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Form1 form1 = new Form1(VelocityMs, AngleDeg);
                form1.Show();
                this.Hide();
            }
            else if (result == DialogResult.No)
                Application.Exit();
            return;
        }
    }
}
