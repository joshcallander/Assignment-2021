using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Assignment_2021
{
    class Player
    {
        // Declare an array of players
        public static generatePlayers[] Players = new generatePlayers[4];

        public int turn = 0;
        public int time = 0;
        public String PlayerCountS;

        // The generatePlayers class with the variables
        public class generatePlayers
        {
            public int[] PropertiesOwned = new int[40]; //properties player owns 
            public int balance = 1500;
            public int cardPrice = 0;
            public bool passGo = false; // check if card is passgo
            public int numberofpropertiesOwned = 0;
            public int Jail = 0; //To tell how many turns spent in jail
            public bool inJail = false;
            //  public int DoubleCount = 0;  //amount of doubles rolles, if a double is rolled they get out of jail
            public int outOfJail = 0; //get out of jail card
            public string playerName;
            public Boolean loser = false; // lose game set to false for each player
            public string playerImageName; //player icon
        }

        // The RegisterPlayer method
        public void RegisterPlayer(string playerName, int i, bool inJail)
        {
            generatePlayers temp = new generatePlayers();

            // Set the values of the array to the values passed to the method
            temp.playerName = playerName;
            temp.inJail = inJail;
            Players[i] = temp;
        }

        // The inJail method
        public void inJail(int currentPlayer)
        {
            // Ser the text box in the form vale
            ((Form4)Form4.ActiveForm).textBoxDisplay.Text = "You are in jail! Press buy button to get out or wait 3 turns...";

            // Set the jail property to current value + 1
            Players[currentPlayer].Jail = Players[currentPlayer].Jail + 1;

            // Disable the roll button
            ((Form4)Form4.ActiveForm).buttonRoll.Enabled = false;

            // If the Jail property equals 3 or the outOfJail property equals 1
            if ((Players[currentPlayer].Jail == 3) || (Players[currentPlayer].outOfJail == 1))
            {
                // Set the inJail property to false
                Players[currentPlayer].inJail = false;

                // Enable the roll button so they can roll the next 3 turns
                ((Form4)Form4.ActiveForm).buttonRoll.Enabled = true;

                // Set the number of outOfJail cards to 0 once it is used
                Players[currentPlayer].outOfJail = 0;
            }
        }

        // The changeBalance method
        public void changeBalance(generatePlayers player, int cashChange)
        {
            // Increase the balance property of the player by the cashChange value passed to the method
            player.balance += cashChange;

            // Call the updateTextBox method in the form
            ((Form4)Form4.ActiveForm).updateTextBox();
        }

        // The Lose method
        public void Lose()
        {
            // Set the loser property to true of the player
            Players[CalcPlayerTurn(PlayerCountS) - 1].loser = true;

            // Disable buttons on the form
            ((Form4)Form4.ActiveForm).buttonRoll.Enabled = false;
            ((Form4)Form4.ActiveForm).buttonBuy.Enabled = false;
            ((Form4)Form4.ActiveForm).buttonDrawCard.Enabled = false;

            // Set the text box value on the form
            ((Form4)Form4.ActiveForm).textBoxDisplay.Text = "You have lost the game!";
        }

        // The CheckIfPlayerLoses method
        public void CheckIfPlayerLoses()
        {
            // Get the player count and declare a counter variable
            int playerCount = Convert.ToInt32(PlayerCountS);
            int count = 0;

            // For each player
            for (int i = 0; i < playerCount; i++)
            {
                // Get the current player
                int currentPlayer = CalcPlayerTurn(PlayerCountS);

                // If the loser property is true
                if (Players[i].loser == true)
                {
                    // Increase the count variable
                    count++;

                    // Stop the timer on the form
                    ((Form4)Form4.ActiveForm).timerScore.Stop();

                    // Call the addHighScore method in the HighScores class passing the username and time
                    HighScores.addHighScore(Players[currentPlayer].playerName, time);
                }

                // If the player is not a loser and the count variable is greather than or equal to the player count - 1
                if (Players[CalcPlayerTurn(PlayerCountS) - 1].loser == false && count >= playerCount - 1)
                {
                    // Set the text box value on the form
                    ((Form4)Form4.ActiveForm).textBoxDisplay.Text = "You have won! Congratulations!";

                    // Stop the timer on the form
                    ((Form4)Form4.ActiveForm).timerScore.Stop();

                    // Call the addHighScore method in the HighScores class passing the username and time
                    HighScores.addHighScore(Players[currentPlayer].playerName, time);

                    // Show a dialog informing the user someone has won
                    DialogResult dialog = MessageBox.Show(Players[CalcPlayerTurn(PlayerCountS) - 1].playerName + " has won!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    // If the user clicks the ok button show the opening form and hide the current form
                    if (dialog == DialogResult.OK)
                    {
                        Form1 form1 = new Form1();
                        ((Form4)Form4.ActiveForm).Hide();
                        form1.Show();
                    }
                }
            }
        }

        // The CalcPlayerTurn method
        public int CalcPlayerTurn(string playerCountS)
        {
            // Get the player count and declare a currentPlayer variable
            int playerCount = Convert.ToInt32(playerCountS);
            int currentPlayer = 1;

            // For each turn
            for (int x = 1; x <= turn; x++)
            {
                // Increase the currentPlayer
                currentPlayer++;

                // If the currentPlayer is greater than the playerCount
                if (currentPlayer > playerCount)
                {
                    // Set the currentPlayer to 1
                    currentPlayer = 1;

                }
            }

            // Return the currentPlayer to the method
            return currentPlayer;
        }
    }
}
