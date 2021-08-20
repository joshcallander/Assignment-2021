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
    class Card
    {
        // Declare an array of cards
        public static generateCards[] Cards = new generateCards[6];

        // Declare the index position
        public int index = 0;

        // The generateCards class with the variables
        public class generateCards
        {
            public string name;
            public int price = 0; //if user needs to pay.
            public int outOfJail = 0; //0 if not, 1 if out of jail card
            public int goToJail = 0; // =1 if its a go to jail card
        }

        // The drawCard method
        public void drawCard(int playerI)
        {
            // Declare the cards
            newCard("Pass Go", 0, 0, 0, 0);
            newCard("Collect $200", 1, 200, 0, 0);
            newCard("Pay $200", 2, -200, 0, 0);
            newCard("Go to Jail", 3, 0, 0, 1);
            newCard("Get out of Jail", 4, 0, 1, 0);
            newCard("Pay $100", 5, -100, 0, 0);

            // A list of images for each card
            List<Image> imageName = new List<Image> { Assignment_2021.Properties.Resources.pass_go, Assignment_2021.Properties.Resources.two_hundred, Assignment_2021.Properties.Resources.two_hundred, Assignment_2021.Properties.Resources.go_to_jail, Assignment_2021.Properties.Resources.out_of_jail, Assignment_2021.Properties.Resources.one_hundred };

            // Generate a random number between 0 and 5
            Random rand = new Random();
            index = rand.Next(0, 5);

            // Set the picture box image to the image associated with the card generated
            ((Form4)Form4.ActiveForm).pictureBoxCard.Image = imageName[index];

            // Set the text box text to the name of the card
            ((Form4)Form4.ActiveForm).textBoxDisplay.Text = Cards[index].name;

            // Change the balance 
            Player.Players[playerI].cardPrice = Cards[index].price; //changes balance if pay or recieve money
            Player.Players[playerI].outOfJail = Cards[index].outOfJail; //changes if player has an outof jail card

            // If the goToJail property is 1 set the inJail property to true
            if (Cards[index].goToJail == 1)
            {
                Player.Players[playerI].inJail = true;
            }

            // If the random number generated is 0, then it is a pass go card so set the passGo property of the player to true
            if (index == 0)
            {
                Player.Players[playerI].passGo = true;
            }

            // Call the button was clicked method
            ((Form4)Form4.ActiveForm).ButtonWasClicked();

            // Enable the End Turn button
            ((Form4)Form4.ActiveForm).buttonEndTurn.Enabled = true;

            // Calculate the current player by calling the CalcPlayerTurn method in the Player class passing the playerCount - 1
            int currentPlayer = Player.CalcPlayerTurn(((Form4)Form4.ActiveForm).PlayerCountS) - 1;

            // Call the changeBalance method in the Player class passing the player and the cardPrice property of the player
            Player.changeBalance(Player.Players[currentPlayer], Player.Players[currentPlayer].cardPrice);

            // If the balance property of the currentPlayer is less than or equal to 0
            if (Player.Players[currentPlayer].balance <= 0)
            {
                // Call the Lose method in the Player class
                Player.Lose();
            }

            // If the inJail property of the currentPlayer equals true
            if (Player.Players[currentPlayer].inJail == true)
            {
                // Set the currentPosition to 10
                currentPosition = 10;

                // Call the movePlayer method passing the current position
                movePlayer(currentPosition);

                // Change the position of the currentPlayer to the current position
                ((Form4)Form4.ActiveForm).position[currentPlayer] = currentPosition;

                // Call the inJail method in the Player class passing the currentPlayer
                Player.inJail(currentPlayer);

                // Enable the Buy button
                ((Form4)Form4.ActiveForm).buttonBuy.Enabled = true;
            }

            // If the passGo property of the currentPlayer equals true
            if (Player.Players[currentPlayer].passGo == true)
            {
                // Change the position of the currentPlayer to 0
                ((Form4)Form4.ActiveForm).position[currentPlayer] = 0;

                // Call the movePlayer method passing the tile 0
                ((Form4)Form4.ActiveForm).movePlayer(0);
            }
        }

        // The new card method
        public void newCard(string name, int i, int price, int outOfJail, int goToJail)
        {
            generateCards temp = new generateCards();

            // Set the values of the array to the values passed to the method
            temp.name = name;
            temp.price = price;
            temp.outOfJail = outOfJail;
            temp.goToJail = goToJail;
            Cards[i] = temp;
        }
    }
}
