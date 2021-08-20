using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2021
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // A counter variable
        public int counter = 0;

        // A list of images
        List<Image> imagesList = new List<Image> { Assignment_2021.Properties.Resources.sheep, Assignment_2021.Properties.Resources.pass_go };

        // Onclick of the next button
        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Increase the counter
            counter++;

            // Set an image variable to the image from the images list with the counter index position
            Image image = imagesList[counter];

            // Set the picture box image to the image variable
            pictureBoxDisplay.Image = image;

            // If the counter variable is greater than 0
            if (counter > 0)
            {
                // Enable the pervious button
                buttonPrevious.Enabled = true;
            }

            // If the counter variable equals the number of elements in the imagesList - 1
            if (counter == imagesList.Count - 1)
            {
                // Disable the next button
                buttonNext.Enabled = false;
            }
        }

        // Onclick of the previous button
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            // Decrease the counter
            counter--;

            // Set an image variable to the image from the images list with the counter index position
            Image image = imagesList[counter];

            // Set the picture box image to the image variable
            pictureBoxDisplay.Image = image;

            // If the counter variable is 0
            if (counter == 0)
            {
                // Disable the previous button
                buttonPrevious.Enabled = false;
            }

            // If the counter variable is less than the number of elements in the imagesList
            if (counter < imagesList.Count)
            {
                // Enable the next button
                buttonNext.Enabled = true;
            }
        }

        // On load of the 
        private void Form3_Load(object sender, EventArgs e)
        {
            // Set the image variable to the first image in the imagesList
            Image image = imagesList[0];

            // Set the picture box image to the image variable
            pictureBoxDisplay.Image = image;
        }
        
        // Onclick of the back button, show the opening form and hide the current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
