// Game developed by Asfand Soomro in February 2023

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace CarGame_CS
{
    public partial class Form1 : Form
    {
        // Current Working Directory
        static string workingDirectory = Environment.CurrentDirectory;
        // Project Directory
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

        // Initial Setup
        PictureBox newBackground = new PictureBox();
        static Car userCar;
        string defaultUserCarColor = "green";
        int handlingSpeed = 10;
        int userSpeed = 10;
        SoundPlayer gameMusic = new SoundPlayer();
        Timer musicTimer = new Timer();

        // Flag
        Boolean gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Make the user car a Car object instead of just PictureBox object
            userCar = new Car(defaultUserCarColor, pbUserCar.Location, 0);
            this.Controls.Add(userCar);
            userCar.BringToFront();

            // Second Image Properties
            newBackground.Size = pbBackground.Size;
            newBackground.Image = pbBackground.Image;
            newBackground.SizeMode = pbBackground.SizeMode;
            // Add the second image to the the form
            this.Controls.Add(newBackground);

            // Start the game music
            Console.WriteLine(projectDirectory);
            gameMusic.SoundLocation = projectDirectory + @"\music\welcome_to_bad_end_theater.wav";
            gameMusic.Play();
            musicTimer.Interval = 104 * 1000; // Length of the music 104 seconds
            musicTimer.Tick += new EventHandler(musicTimer_Tick);
            musicTimer.Start();

            this.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!gameOver)
            {
                Point currentLocation = userCar.Location;
                // To move the car right when the user presses the right arrow key
                if (e.KeyCode == Keys.Right && currentLocation.X < 509)
                {
                    Point updatedLocation = new Point(currentLocation.X + handlingSpeed, currentLocation.Y);
                    userCar.Location = updatedLocation;
                    //userCar.RotateCar("right", 30);
                }
                // To move the car left when the user presses the left arrow key
                else if (e.KeyCode == Keys.Left && currentLocation.X > 189)
                {
                    Point updatedLocation = new Point(currentLocation.X - handlingSpeed, currentLocation.Y);
                    userCar.Location = updatedLocation;
                    //userCar.RotateCar("left", 30);
                }
                // Makes the user's car jump
                /*else if (e.KeyCode == Keys.Space)
                {
                    userCar.BringToFront();
                    userCar.Size = new Size(userCar.Size.Width + 40, userCar.Size.Height + 40);
                }*/
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Update the location of first image with give speed
            Point updatedBackgroundLocation = new Point(pbBackground.Location.X, pbBackground.Location.Y + userSpeed);

            // Apply the updated locations for both moveable background images
            pbBackground.Location = updatedBackgroundLocation;
            newBackground.Location = new Point(pbBackground.Location.X, pbBackground.Location.Y - (pbBackground.Size.Height - 25));

            // When the first bg image reaches the end set its location to default
            if (pbBackground.Location.Y >= this.Height - (userSpeed + 50))
            {
                pbBackground.Location = new Point(0, 0);
            }

            // Check if collision
            //if (userCar.Bounds.IntersectsWith(randCar.Bounds))
            foreach (Car theCar in this.Controls.OfType<Car>())
            {
                if (theCar == userCar) continue;

                if (distanceBetweenCars(userCar.Location, theCar.Location) <= (double)70.0) {
                    Console.WriteLine(distanceBetweenCars(userCar.Location, theCar.Location));
                    pbFire.Enabled = true;
                    pbFire.Visible = true;
                    pbFire.Location = new Point(userCar.Location.X, userCar.Location.Y - 63);
                    btnRestart.Enabled = true;
                    btnRestart.Visible = true;
                    gameTimer.Stop();
                    randomCarsTimer.Stop();
                    gameOver = true;
                    break;
                }
            }

            //this.Refresh();
        }

        // Generates a random car with each tick
        private void randomCarsTimer_Tick(object sender, EventArgs e)
        {
            // A random object
            Random randObj = new Random();

            // Random Car
            string[] carColors = {"red", "green", "pink", "yellow"};
            int randColorIndex = randObj.Next(0, carColors.Length);
            int randX = randObj.Next(189, 509); // Random X position with the road boundaries
            Point randLocation = new Point(randX, -40);
            int randSpeed = randObj.Next(3, 16);
            Car randCar = new Car(carColors[randColorIndex], randLocation, randSpeed);
            this.Controls.Add(randCar);
            randCar.BringToFront();
            randCar.MoveCar();

            toolStrip.BringToFront(); // Bring the toolbar in front rather than the random car

            // Next Random car timer starts anywehre between 1 to 10 seconds
            int randInterval = randObj.Next(1, 10);
            randomCarsTimer.Interval = randInterval * 1000;

            //this.Refresh();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            if(gameOver)
            {
                gameOver = false;
                pbFire.Visible = false;
                pbFire.Enabled = false;
                btnRestart.Visible = false;
                btnRestart.Enabled = false;
                randomCarsTimer.Start();
                gameTimer.Start();
            }
        }

        // Plays the music when it ends
        private void musicTimer_Tick(object sender, EventArgs e)
        {
            gameMusic.Play();
        }

        // Finds the distance between two Locations of cars
        public static double distanceBetweenCars(Point location1, Point location2)
        {
            double distance = Math.Sqrt(
                Math.Pow(location2.X - location1.X, 2) + Math.Pow(location2.Y - location1.Y, 2)
            );
            return distance;
        }
    }
}
