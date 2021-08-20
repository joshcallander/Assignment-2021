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
    public partial class Form6 : Form
    {
        // A playerCount variable
        private int playerCount;

        // A counter variable
        public int count = 0;

        // A oldText variable
        public string oldText;

        // An array to hold the piece selection for each player
        public string[] playersPieces = new string[5];

        // An array to hold the username selection for each player
        public string[] playersUsernames = new string[5];

        // The form passing the playerCount
        public Form6(int playerCount)
        {
            InitializeComponent();
            buttonNext.Enabled = false;

            // Set the playerCount to the playerCount passed to the form
            this.playerCount = playerCount;

            // Call the selectPiece method
            selectPiece();
        }

        // The selectPiece method
        public void selectPiece()
        {
            // Increase the counter variable
            count++;

            // Set the value of the label
            labelStatus.Text = "Enter a username & select character for Player " + count.ToString();
        }

        // Onclick of the Next button
        private void buttonNext_Click(object sender, EventArgs e) //next button
        {
            // If the value of the username text box is not equal to nothing
            if (textBoxUsername.Text != "")
            {
                // Disable the Next button
                buttonNext.Enabled = false;
                
                // If the count is less than the playerCount
                if (count < playerCount)
                {
                    // Call the selectPiece method
                    selectPiece();
                }

                // If the count equals the playerCount
                else if (count == playerCount)
                {
                    // Show the game form passing the playerPieces and playersUsernames array and playerCount and hide the current form
                    Form4 form4 = new Form4(playersPieces, playersUsernames, playerCount);
                    form4.Show();
                    this.Hide();
                }

                // If the Jandals check box is checked then disable the Jandals check box
                if (checkBoxJandals.Checked == true)
                {
                    checkBoxJandals.Enabled = false;
                }

                // If the Sheep check box is checked then disable the Sheep check box
                if (checkBoxSheep.Checked == true)
                {
                    checkBoxSheep.Enabled = false;
                }

                // If the Surfboard check box is checked then disable the Surfboard check box
                if (checkBoxSurfboard.Checked == true)
                {
                    checkBoxSurfboard.Enabled = false;
                }

                // If the Vegemite check box is checked then disable the Vegemite check box
                if (checkBoxVegemite.Checked == true)
                {
                    checkBoxVegemite.Enabled = false;
                }

                // Clear the username text box
                textBoxUsername.Clear();
            }
            
            // Else the username is empty so show a alert to the user
            else
            {
                MessageBox.Show("Please enter a username!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Onclick of the Back button, show the number of player selection form and hide the current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }

        // Onchange of the Jandals check box
        private void checkBoxJandals_CheckedChanged(object sender, EventArgs e)
        {
            // If the Jandals check box is checked
            if (checkBoxJandals.Checked == true)
            {
                // Enable the Next button
                buttonNext.Enabled = true; //Enable next button once piece is selected

                // Add the piece name to the playersPieces array with the count index position
                playersPieces[count] = "Jandals";

                // Uncheck the other text boxes
                checkBoxSheep.Checked = false;
                checkBoxSurfboard.Checked = false;
                checkBoxVegemite.Checked = false;

                // Focus on the username text box
                textBoxUsername.Focus();
            }
        }

        // Onchange of the Sheep check box
        private void checkBoxSheep_CheckedChanged(object sender, EventArgs e)
        {
            // If the Sheep check box is checked
            if (checkBoxSheep.Checked == true)
            {
                // Enable the Next button
                buttonNext.Enabled = true;

                // Add the piece name to the playersPieces array with the count index position
                playersPieces[count] = "Sheep";

                // Uncheck the other text boxes
                checkBoxJandals.Checked = false;
                checkBoxSurfboard.Checked = false;
                checkBoxVegemite.Checked = false;

                // Focus on the username text box
                textBoxUsername.Focus();
            }
        }

        // Onchange of the Surfboard check box
        private void checkBoxSurfboard_CheckedChanged(object sender, EventArgs e)
        {
            // If the Surfboard check box is checked
            if (checkBoxSurfboard.Checked == true)
            {
                // Enable the Next button
                buttonNext.Enabled = true;

                // Add the piece name to the playersPieces array with the count index position
                playersPieces[count] = "Surfboard";

                // Uncheck the other text boxes
                checkBoxJandals.Checked = false;
                checkBoxSheep.Checked = false;
                checkBoxVegemite.Checked = false;

                // Focus on the username text box
                textBoxUsername.Focus();
            }
        }

        // Onchange of the Vegemite check box
        private void checkBoxVegemite_CheckedChanged(object sender, EventArgs e)
        {
            // If the Vegemite check box is checked
            if (checkBoxVegemite.Checked == true)
            {
                // Enable the Next button
                buttonNext.Enabled = true;

                // Add the piece name to the playersPieces array with the count index position
                playersPieces[count] = "Vegemite";

                // Uncheck the other text boxes
                checkBoxJandals.Checked = false;
                checkBoxSheep.Checked = false;
                checkBoxSurfboard.Checked = false;

                // Focus on the username text box
                textBoxUsername.Focus();
            }
        }

        // Onchange of the user name text box
        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.Text.All(chr => char.IsLetter(chr)))
            {
                // if the length of the username text box is less than 15 characters
                if (textBoxUsername.Text.Length < 15)
                {
                    oldText = textBoxUsername.Text;
                    textBoxUsername.Text = oldText;
                }

                textBoxUsername.BackColor = System.Drawing.Color.White;
                textBoxUsername.ForeColor = System.Drawing.Color.Black;
            }

            else
            {
                textBoxUsername.Text = oldText;
                textBoxUsername.BackColor = System.Drawing.Color.White;
                textBoxUsername.ForeColor = System.Drawing.Color.Red;
            }

            // If the length of the username text box is greater than 14 characters
            if (textBoxUsername.Text.Length > 14)
            {
                // Set the value of the username text box to the old value of the text box
                textBoxUsername.Text = oldText;

                // 
                textBoxUsername.BackColor = System.Drawing.Color.White;
                textBoxUsername.ForeColor = System.Drawing.Color.Red;
            }

            textBoxUsername.SelectionStart = textBoxUsername.Text.Length;
            playersUsernames[count-1] = textBoxUsername.Text;
        }
    }
}
