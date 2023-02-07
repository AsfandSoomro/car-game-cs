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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

    }
}
