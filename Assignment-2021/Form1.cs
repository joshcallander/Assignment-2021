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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // On click of the start button, show the player selection form and hide the current form
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        // On click of the help button, show the help form and hide the current form
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }

        // On click of the high scores button, show the high scores button and hide the current form
        private void buttonHighScores_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            this.Hide();
            form7.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // Show a dialog asking the user if they want to exit the application
            DialogResult dialog = MessageBox.Show("Do you really want to exit the application?", "Exit", MessageBoxButtons.YesNo);

            // If the user clicks the yes button
            if (dialog == DialogResult.Yes)
            {
                // Close the form
                Application.Exit();
            }
        }
    }
}
