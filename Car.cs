using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CarGame_CS
{
    class Car : PictureBox
    {
        // Current Working Directory
        static string workingDirectory = Environment.CurrentDirectory;
        // Project Directory
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;


        // Attributes
        private string color = "red";
        private int speed = 5;

        public Car(string carColor, Point carLocation, int carSpeed)
        {
            this.color = carColor;
            this.Location = carLocation;
            this.speed = carSpeed;
            this.ApplyCarGraphics();
        }

        // Make the PictureBox import car picture according to provided color
        private void ApplyCarGraphics()
        {
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("car_{0}", this.color));
            this.Size = new Size(76, 114);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackColor = Color.FromArgb(250, 69, 75, 76);
        }

        // Rotates the car either left or right for turn
        public void RotateCar(string direction, float angle)
        {
            this.Image.Dispose();
            this.Image = (Image)Properties.Resources.ResourceManager.GetObject(String.Format("car_{0}_rotated_{1}", this.color, direction));
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Starts moving the car down the screen
        public void MoveCar()
        {
            Timer moveCarTimer = new Timer();
            moveCarTimer.Enabled = true;
            moveCarTimer.Interval = 1;
            moveCarTimer.Tick += new EventHandler(movecarTimer_Tick);
            moveCarTimer.Start();
        }

        // Move car timer
        private void movecarTimer_Tick(object sender, EventArgs e)
        {
            // If the car is down the road
            Form gameForm = Application.OpenForms[0];
            if (this.Location.Y >= gameForm.Height)
            {
                // Destroy the timer
                var currentTimer = (Timer)sender;
                currentTimer.Stop();
                currentTimer.Dispose();

                // Destroy the car
                this.Enabled = false;
                this.Dispose();
            }
            // Else move the car downwards
            else
            {
                this.Location = new Point(this.Location.X, this.Location.Y + this.speed);
            }
        }
    }
}
