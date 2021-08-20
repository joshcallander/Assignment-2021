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
    public partial class Form4 : Form
    {
        // The classes
        private Card Card = new Card();
        private Player Player = new Player();
        private Property Property = new Property();

        // Variables to reference
        public String PlayerCountS;
        public int[] position = new int[] { 0, 0, 0, 0 };
        public int currentPosition;
        private int Dice;
        private int width = 100;
        private int height = 60;

        public Form4(string[] playerPieces, string[] playersUsernames, int playerCount)
        {
            InitializeComponent();

            // Set the PlayerCountS variable in the Player class to the playerCount as a string
            Player.PlayerCountS = playerCount.ToString();

            // Set the PlayerCountS variable to the playerCount as a string
            PlayerCountS = playerCount.ToString();

            // Set the value of the text box to directions
            textBoxDisplay.Text = playersUsernames[0] + "'s turn to start. Press the roll button.";

            // Generate the properties calling the RegisterProperty method in the Property class
            Property.RegisterProperty("GO", false, "Null", 0, 0, panelGame.Width - width, panelGame.Height - width, width, width);
            Property.RegisterProperty("Te Puke Kiwifruit", true, "Brown", 60, 1, width + (8 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Community Chest", false, "Card", 0, 2, width + (7 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Ohakune Carrot", true, "Brown", 60, 3, width + (6 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Pay $200", false, "Null", 0, 4, width + (5 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Picton Ferry", true, "Station", 200, 5, width + (4 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Larnach Castle", true, "Purple", 100, 6, width + (3 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Chance", false, "Card", 0, 7, width + (2 * height), panelGame.Height - width, height, width);
            Property.RegisterProperty("Waitangi Treaty Grounds", true, "Purple", 100, 8, width + height, panelGame.Height - width, height, width);
            Property.RegisterProperty("Te Papa", true, "Purple", 120, 9, width + 100, panelGame.Height - width, height, width);
            Property.RegisterProperty("Jail", false, "Null", 0, 10, 0, panelGame.Height - width, height, width);
            Property.RegisterProperty("Queenstown Ski Fields", true, "Pink", 140, 11, 0, panelGame.Height - width - height, width, height);
            Property.RegisterProperty("Electrics", true, "Utility", 150, 12, 0, panelGame.Height - width - (2 * height), width, height);
            Property.RegisterProperty("Lake Taupo", true, "Pink", 140, 13, 0, panelGame.Height - width - (3 * height), width, height);
            Property.RegisterProperty("Cape Reinga Lighthouse", true, "Pink", 160, 14, 0, panelGame.Height - width - (4 * height), width, height);
            Property.RegisterProperty("Port of Tauranga", true, "Station", 200, 15, 0, panelGame.Height - width - (5 * height), width, height);
            Property.RegisterProperty("Mt Cook", true, "Orange", 180, 16, 0, panelGame.Height - width - (6 * height), width, height);
            Property.RegisterProperty("Community Chest", false, "Card", 0, 17, 0, panelGame.Height - width - (7 * height), width, height);
            Property.RegisterProperty("Milford Sound", true, "Orange", 180, 18, 0, panelGame.Height - width - (8 * height), width, height);
            Property.RegisterProperty("Fox Glacier", true, "Orange", 180, 19, 0, panelGame.Height - width - (9 * height), width, height);
            Property.RegisterProperty("Free Parking", false, "Null", 0, 20, 0, 0, width, width);
            Property.RegisterProperty("Moeraki Boulders, Oamaru", true, "Red", 220, 21, width, 0, height, width);
            Property.RegisterProperty("Chance", false, "Card", 0, 22, width + height, 0, height, width);
            Property.RegisterProperty("Golden Bay", true, "Red", 220, 23, width + (2 * height), 0, height, width);
            Property.RegisterProperty("Ninety Mile Beach", true, "Red", 240, 24, width + (3 * height), 0, height, width);
            Property.RegisterProperty("Dunedin Railway Station", true, "Station", 200, 25, width + (4 * height), 0, height, width);
            Property.RegisterProperty("Art Deco Buildings, Napier", true, "Yellow", 260, 26, width + (5 * height), 0, height, width);
            Property.RegisterProperty("Mt Maunganui", true, "Yellow", 260, 27, width + (6 * height), 0, height, width);
            Property.RegisterProperty("Mobile Phone Company", true, "Utility", 150, 28, width + (7 * height), 0, height, width);
            Property.RegisterProperty("Waitomo Caves", true, "Yellow", 280, 29, width + (8 * height), 0, height, width);
            Property.RegisterProperty("Go To Jail", false, "Null", 0, 30, width + (9 * height), 0, height, width);
            Property.RegisterProperty("The Square, Palmerston North", true, "Green", 300, 31, panelGame.Width - width, width, width, height);
            Property.RegisterProperty("Cathedral Square", true, "Green", 300, 32, panelGame.Width - width, width + height, width, height);
            Property.RegisterProperty("Community Chest", false, "Card", 0, 33, panelGame.Width - width, width + (2 * height), width, height);
            Property.RegisterProperty("Cable Cars, Wellington", true, "Green", 320, 34, panelGame.Width - width, width + (3 * height), width, height);
            Property.RegisterProperty("Auckland International Airport", true, "Station", 200, 35, panelGame.Width - width, width + (4 * height), width, height);
            Property.RegisterProperty("Chance", false, "Card", 0, 36, panelGame.Width - width, width + (5 * height), width, height);
            Property.RegisterProperty("Rangitoto", true, "Blue", 350, 37, panelGame.Width - width, width + (6 * height), width, height);
            Property.RegisterProperty("Pay 200", false, "Null", 0, 38, panelGame.Width - width, width + (7 * height), width, height);
            Property.RegisterProperty("Pukekura Park Festival of Lights", true, "Blue", 400, 39, panelGame.Width - width, width + (8 * height), width, height);
            
            // For each of the 4 rich text boxes
            for (int i = 0; i < 4; i++)
            {
                // Call the RegisterPlayer method in the Player class
                Player.RegisterPlayer(playersUsernames[i], i, false);

                // If the i value is less than the player count
                if (i < playerCount)
                {
                    // Set the playerImageName for the Player in the Player class to the correct piece
                    Player.Players[i].playerImageName = playerPieces[i + 1];
                }
            }

            // Call the updateTextBox method
            updateTextBox();

            // Disable the buttons
            buttonDrawCard.Enabled = false;
            buttonBuy.Enabled = false;
        }

        // The updateTextBox method
        public void updateTextBox()
        {
            // Set the rich text boxes to contain the playerName, playerImage, balance, properties owned
            richTextBox1.Text = Player.Players[0].playerName + "\n" + Player.Players[0].playerImageName + "\n" + Player.Players[0].balance + "\n" + Property.PropertiestoString(Player.Players[0].PropertiesOwned);
            richTextBox2.Text = Player.Players[1].playerName + "\n" + Player.Players[1].playerImageName + "\n" + Player.Players[1].balance + "\n" + Property.PropertiestoString(Player.Players[1].PropertiesOwned);
            richTextBox3.Text = Player.Players[2].playerName + "\n" + Player.Players[2].playerImageName + "\n" + Player.Players[2].balance + "\n" + Property.PropertiestoString(Player.Players[2].PropertiesOwned);
            richTextBox4.Text = Player.Players[3].playerName + "\n" + Player.Players[3].playerImageName + "\n" + Player.Players[3].balance + "\n" + Property.PropertiestoString(Player.Players[3].PropertiesOwned);
            
            // Add a new line to the rich text boxes with the number of outOfJail cards for each player
            richTextBox1.AppendText("Out of jail card - " + Player.Players[0].outOfJail + "\n");
            richTextBox2.AppendText("Out of jail card - " + Player.Players[1].outOfJail + "\n");
            richTextBox3.AppendText("Out of jail card - " + Player.Players[2].outOfJail + "\n");
            richTextBox4.AppendText("Out of jail card - " + Player.Players[3].outOfJail + "\n");
        }

        // The movePlayer method
        public void movePlayer(int position)
        {
            // Get the playerImage name of the player
            switch (Player.Players[Player.CalcPlayerTurn(PlayerCountS) - 1].playerImageName)
            {
                // If the playerImageName value is Jandal
                case "Jandal":
                    // Get the x and y co-ordinates of the tile passed to the method
                    int x = Property.tile[position].X;
                    int y = Property.tile[position].Y;

                    // Change the location of the player to the new co-ordinates
                    pictureBox1.Location = new Point(x, y);
                    break;

                // If the playerImageName value is Sheep
                case "Sheep":
                    // Get the x and y co-ordinates of the tile passed to the method
                    x = Property.tile[position].X;
                    y = Property.tile[position].Y;

                    // Change the location of the player to the new co-ordinates
                    pictureBox2.Location = new Point(x, y);
                    break;

                // If the playerImageName value is Surfboard
                case "Surfboard":
                    // Get the x and y co-ordinates of the tile passed to the method
                    x = Property.tile[position].X;
                    y = Property.tile[position].Y;

                    // Change the location of the player to the new co-ordinates
                    pictureBox3.Location = new Point(x, y);
                    break;

                // If the playerImageName value is Vegemite
                case "Vegemite":
                    // Get the x and y co-ordinates of the tile passed to the method
                    x = Property.tile[position].X;
                    y = Property.tile[position].Y;

                    // Change the location of the player to the new co-ordinates
                    pictureBox4.Location = new Point(x, y);
                    break;

                // Return an error message
                default:
                    textBoxDisplay.Text = "An error occured";
                    break;
            }
        }

        // Onclick of the Roll button
        private void buttonRoll_Click(object sender, EventArgs e)
        {
            // Enable the Buy button
            buttonBuy.Enabled = true;

            // Call the updateTextBox method
            updateTextBox();

            // Disable the Draw Card and Roll button
            buttonDrawCard.Enabled = false;
            buttonRoll.Enabled = false;

            // Generate a random number between 2 and 12 for the roll
            Random rand = new Random();
            Dice = rand.Next(2, 13);

            // Set the value of the text box to the roll number
            textBoxDisplay.Text += "You rolled a " + Dice; //prints number
            
            // Get the current player by calling the CalcPlayerTurn method in the Player class - 1
            int currentPlayer = Player.CalcPlayerTurn(PlayerCountS) - 1;

            // Update the current position of the player to add the dice
            currentPosition = position[currentPlayer] + Dice;

            // If the inJail property of the player is true
            if (Player.Players[currentPlayer].inJail == true)
            {
                // Call the inJail method in the Player class passing the current player
                Player.inJail(currentPlayer);
            }

            // If the current positoon is 10 and the inJail property of the player is false
            if ((currentPosition == 10) && (Player.Players[currentPlayer].inJail == false))
            {
                // Disable the Buy button
                buttonBuy.Enabled = false;
            }

            // If the currentPosition is greater than or equal to 40
            if (currentPosition >= 40)
            {
                // Call the changeBalance method in the Player class passing the current player and the balance change amount 
                Player.changeBalance(Player.Players[currentPlayer], 200);

                // Set the position of the player to the current position - 40
                position[currentPlayer] = currentPosition - 40;

                // Set the current position to the new position
                currentPosition = position[currentPlayer];
            }

            // If the colour property of the property is a card
            if (Property.Properties[currentPosition].colour == "Card")
            {
                // Disable the Roll button, Buy button and End Turn Button and enable the Draw Card button
                buttonRoll.Enabled = false;
                buttonBuy.Enabled = false;
                buttonEndTurn.Enabled = false;

                buttonDrawCard.Enabled = true;
            }

            // If the currentPosition is 4 or 38 then the player landed on a pay $200 square
            if ((currentPosition == 4) || (currentPosition == 38))
            {
                // Call the changeBalance method in the Player class passing the player and the -$200
                Player.changeBalance(Player.Players[currentPlayer], -200);
            }

            // If the currentPosition is 30 then the player landed on the go to jail square
            if (currentPosition == 30)
            {
                // Change the currentPosition to 10
                currentPosition = 10;

                // Call the movePlayer method passing the current position
                movePlayer(currentPosition);

                // Set the inJail property of the player to true
                Player.Players[currentPlayer].inJail = true;

                // Call the inJail method in the Player class passing the currentPlayer
                Player.inJail(currentPlayer);
            }

            // Set the position of the player to the current position
            position[currentPlayer] = currentPosition;

            // Change the rich text box to the position with the property name, value and type/ colour
            richTextBox5.Text = "Position " + currentPosition;
            richTextBox5.AppendText("\r\n" + Property.Properties[currentPosition].Name);
            richTextBox5.AppendText("\r\n" + "Value " + Property.Properties[currentPosition].value);
            richTextBox5.AppendText("\r\n" + "Type " + Property.Properties[currentPosition].colour);
            richTextBox5.ScrollToCaret();

            // If the checkifOwned method passing the current player and current position returns false
            if (checkifOwned(currentPlayer, currentPosition) == false)
            {
                // Deduct the rent by calling the changeBalance method in the Player class passing the current player and value returned from the GetRent method passing the Dice roll
                Player.changeBalance(Player.Players[currentPlayer], -GetRent(Dice));

                // Add the rent to the owner by calling the changeBalance method in the Player class passing the owner and value returned from the GetRent method passing the Dice roll
                Player.changeBalance(Player.Players[Property.Properties[currentPosition].Owner], GetRent(Dice)); // add rent to owner
            }

            // Call the movePlayer method passing the current position
            movePlayer(currentPosition);

            // If the loser property of the player is true or the balance of the player is less than or equal to 0
            if (Player.Players[currentPlayer].loser == true || Player.Players[currentPlayer].balance <= 0)
            {
                // Call the Lose method in the Player class
                Player.Lose();
            }

            // Call the CheckIfPlayerLoses method in the Player class
            Player.CheckIfPlayerLoses();

            // Set the value of the text box to the player name and the player image name
            textBoxDisplay.Text = Player.Players[Player.CalcPlayerTurn(PlayerCountS)].playerName + "\r\n" + Player.Players[currentPlayer].playerImageName;
        }

        // The checkifOwned method
        public bool checkifOwned(int currentPlayer, int currentPosition)
        {
            // If the properties owned by the currentPlayer does not equal the current position and the owned property of the currentPosition is true
            if ((Player.Players[currentPlayer].PropertiesOwned[currentPosition] != currentPosition) && (Property.Properties[currentPosition].owned == true))
            {
                // Return false
                return false;
            }

            else
            {
                // Return true
                return true;
            }
        }

        // The GetRent method
        public int GetRent(int Dice)
        {
            // Get the colour property of the property
            switch (Property.Properties[currentPosition].colour)
            {
                // If the colour is Null
                case "Null":
                    // The rent is 0
                    Property.Properties[currentPosition].rent = 0;
                    break;

                // If the colour is Brown
                case "Brown":
                    // Then the rent is 4
                    Property.Properties[currentPosition].rent = 4;
                    break;

                // If the colour is Card
                case "Card":
                    // Then the rent is 0
                    Property.Properties[currentPosition].rent = 0;
                    break;

                // If the colour is Station
                case "Station":
                    // Then the rent is 25
                    Property.Properties[currentPosition].rent = 25;
                    break;

                // If the colour is Utility
                case "Utility":
                    // Then the rent is the dice roll * 4
                    Property.Properties[currentPosition].rent = Dice * 4;
                    break;

                // If the colour is Purple
                case "Purple":
                    // Then the rent is 8
                    Property.Properties[currentPosition].rent = 8;
                    break;

                // If the colour is Pink
                case "Pink":
                    // Then the rent is 12
                    Property.Properties[currentPosition].rent = 12;
                    break;

                // If the colour is Orange
                case "Orange":
                    // Then the rent is 16
                    Property.Properties[currentPosition].rent = 16;
                    break;

                // If the colour is Red
                case "Red":
                    // Then the rent is 20
                    Property.Properties[currentPosition].rent = 20;
                    break;

                // If the colour is Yellow
                case "Yellow":
                    // Then the rent is 22
                    Property.Properties[currentPosition].rent = 22;
                    break;

                // If the colour is Green
                case "Green":
                    // Then the rent is 28
                    Property.Properties[currentPosition].rent = 28;
                    break;

                // If the colour is Blue
                case "Blue":
                    // Then the rent is 50
                    Property.Properties[currentPosition].rent = 50;
                    break;
            }

            // Return the rent property of the property
            return Property.Properties[currentPosition].rent;
        }

        // Onclick of the Buy button
        private void buttonBuy_Click(object sender, EventArgs e)
        {
            // Calculate the current player by calling the CalcPlayerTurn method in the Player class passing the playerCount - 1
            int currentPlayer = Player.CalcPlayerTurn(PlayerCountS) - 1;

            // If the buyable property of the property equals true and the owned property of the property equals false and the balance property of the player is greater than or equal to the value property of the property
            if ((Property.Properties[currentPosition].buyable == true) && (Property.Properties[currentPosition].owned == false) && (Player.Players[currentPlayer].balance >= Property.Properties[currentPosition].value))
            {
                // Call the changeBalance method in the Player class passing the currentPlayer and the value property of the property
                Player.changeBalance(Player.Players[currentPlayer], -Property.Properties[currentPosition].value);

                // Add the current position of currentPlayer to PropertiesOwned at the numberofpropertiesOwned index position.
                Player.Players[currentPlayer].PropertiesOwned[Player.Players[currentPlayer].numberofpropertiesOwned] = currentPosition;
                
                // Set the owned property of the property to true
                Property.Properties[currentPosition].owned = true;

                // Set the Owner property of the property to the currentPlayer
                Property.Properties[currentPosition].Owner = currentPlayer;

                // Increase the numberofpropertiesOwned property for the player
                Player.Players[currentPlayer].numberofpropertiesOwned++;
                
                // Call the updateTextBox method
                updateTextBox();

                // Disable the Buy button
                buttonBuy.Enabled = false;
            }

            // Else if the currentPosition is 10 and the inJail property of the player equals true
            else if ((currentPosition == 10) && (Player.Players[currentPlayer].inJail == true))
            {
                // Call the changeBalance method in the Player class passing the currentPlayer and the -$100 for the fine
                Player.changeBalance(Player.Players[currentPlayer], -100);

                // Disable the Buy button and enable the Roll button
                buttonBuy.Enabled = false;
                buttonRoll.Enabled = true;

                // Set the inJail property of the currentPlayer to false
                Player.Players[currentPlayer].inJail = false;
            }

            else
            {
                // Set the value of the text box
                textBoxDisplay.Text = "NOT ENOUGH MONEY OR UNAVAILABLE";
            }

            // If the balance property of the currentPlayer is less than or equal to 0
            if (Player.Players[currentPlayer].balance <= 0)
            {
                // Call the lose method in the Player class
                Player.Lose();
            }
        }

        // Onclick of the Draw Card button
        private void buttonDrawCard_Click(object sender, EventArgs e)
        {
            // Call the drawCard method in the Card class passing the value returned from the CalcPlayerTurn method in the Player class passing the playerCount - 1
            Card.drawCard(Player.CalcPlayerTurn(PlayerCountS) - 1);

            // Disable the Draw Card button
            buttonDrawCard.Enabled = false;
        }

        // Onclick of the End Turn button
        private void buttonEndTurn_Click(object sender, EventArgs e)
        {
            // Increase the turn variable in the Player class
            Player.turn++;

            // Calculate the current player by calling the CalcPlayerTurn method in the Player class passing the playerCount - 1
            int currentPlayer = Player.CalcPlayerTurn(PlayerCountS) - 1;

            // Set the value of the text box to the player name and the player image name
            textBoxDisplay.Text = Player.Players[Player.CalcPlayerTurn(PlayerCountS)].playerName + "\r\n" + Player.Players[currentPlayer].playerImageName;
            
            // Enable the Roll button and disable the Buy button
            buttonRoll.Enabled = true;
            buttonBuy.Enabled = false;

            // If the inJail property of the player is true
            if (Player.Players[currentPlayer].inJail == true)
            {
                // Set the currentPosition to 10
                currentPosition = 10;

                // Call the movePlayer method passing the currentPosition
                movePlayer(currentPosition);

                // Set the position of the currentPlayer to the currentPosition
                position[currentPlayer] = currentPosition;

                // Call the inJail method in the Player class passing the currentPlayer
                Player.inJail(currentPlayer);
            }

            // If the loser property of the currentPlayer is true or the balance property of the currentPlayer is less than or equal to 0
            if (Player.Players[currentPlayer].loser == true || Player.Players[currentPlayer].balance <= 0)
            {
                // Call the Lose method in the Player class
                Player.Lose();
            }

            // Call the CheckIfPlayerLoses method in the Player class
            Player.CheckIfPlayerLoses();
        }

        // Ontick of the score timer
        private void timerScore_Tick(object sender, EventArgs e)
        {
            // Increase the time variable in the Player class
            Player.time++;
        }
    }
}
