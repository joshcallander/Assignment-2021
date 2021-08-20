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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // A player count variable
        public int playerCount;

        // Onchange of the 2 players checkbox
        private void checkBoxTwoPlayers_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkbox is checked
            if (checkBoxTwoPlayers.Checked == true)
            {
                // Set the other 2 checkboxes to be unchecked
                checkBoxThreePlayers.Checked = false;
                checkBoxFourPlayers.Checked = false;

                // Enable the start button
                buttonStart.Enabled = true;
            }
        }

        // Onchange of the 3 players checkbox
        private void checkBoxThreePlayers_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkbox is checked
            if (checkBoxThreePlayers.Checked == true)
            {
                // Set the other 2 checkboxes to be unchecked
                checkBoxTwoPlayers.Checked = false;
                checkBoxFourPlayers.Checked = false;

                // Enable the start button
                buttonStart.Enabled = true;
            }
        }

        // Onchange of the 4 players checkbox
        private void checkBoxFourPlayers_CheckedChanged(object sender, EventArgs e)
        {
            // If the checkbox is checked
            if (checkBoxFourPlayers.Checked == true)
            {
                // Set the other 2 checkboxes to be unchecked
                checkBoxTwoPlayers.Checked = false;
                checkBoxThreePlayers.Checked = false;

                // Enable the start button
                buttonStart.Enabled = true;
            }
        }

        // Onclick of the start button
        private void buttonStart_Click(object sender, EventArgs e)
        {
            // If the 2 players checkbox is checked
            if (checkBoxTwoPlayers.Checked == true) {
                // Set the player count to 2
                playerCount = 2;

                // Show the username and icon selection form passing the player count and hide the current form
                Form6 form6 = new Form6(playerCount);
                this.Hide();
                form6.Show();
            }

            // If the 3 players checkbox is checked
            else if (checkBoxThreePlayers.Checked == true)
            {
                // Set the player count to 3
                playerCount = 3;

                // Show the username and icon selection form passing the player count and hide the current form
                Form6 form6 = new Form6(playerCount);
                this.Hide();
                form6.Show();
            }

            // If the 4 players checkbox is checked
            else if (checkBoxFourPlayers.Checked == true)
            {
                // Set the player count to 4
                playerCount = 4;

                // Show the username and icon selection form passing the player count and hide the current form
                Form6 form6 = new Form6(playerCount);
                this.Hide();
                form6.Show();
            }

            // Else the user has not checked any checkbox
            else
            {
                // Display an error message telling the user to select the number of players
                MessageBox.Show("Please select the number of players.");
            }
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
