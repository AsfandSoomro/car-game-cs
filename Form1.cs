using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame_CS
{
    public partial class Form1 : Form
    {
        // Runtime Controls
        PictureBox newBackground = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Second Image Properties
            newBackground.Size = pbBackground.Size;
            // Rotate the image to 180 degrees for better view (no hard bump)
            Bitmap rotatedImage = new Bitmap(pbBackground.Image);
            using (Graphics g = Graphics.FromImage(rotatedImage)) {
                g.RotateTransform(180);

            }
            newBackground.Image = rotatedImage;
            newBackground.SizeMode = pbBackground.SizeMode;
            // Add the second image to the the form
            this.Controls.Add(newBackground);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int moveSpeed = 10;
            Point currentLocation = pbUserCar.Location;
            // To move the car right when the user presses the right arrow key
            if (e.KeyCode == Keys.Right && currentLocation.X < 509) {
                Point updatedLocation = new Point(currentLocation.X + moveSpeed, currentLocation.Y);
                pbUserCar.Location = updatedLocation;
            }
            // To move the car left when the user presses the left arrow key
            if (e.KeyCode == Keys.Left && currentLocation.X > 189)
            {
                Point updatedLocation = new Point(currentLocation.X - moveSpeed, currentLocation.Y);
                pbUserCar.Location = updatedLocation;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Update the location of first image with give speed
            int speed = 15;
            Point updatedBackgroundLocation = new Point(pbBackground.Location.X, pbBackground.Location.Y + speed);

            // Apply the updated locations for both moveable background images
            pbBackground.Location = updatedBackgroundLocation;
            newBackground.Location = new Point(pbBackground.Location.X, pbBackground.Location.Y - (pbBackground.Size.Height - 25));

            // When the first bg image reaches the end set its location to default
            if (pbBackground.Location.Y >= this.Height - (speed + 50))
            {
                pbBackground.Location = new Point(0, 0);
            }

            this.Refresh();
        }

    }
}
