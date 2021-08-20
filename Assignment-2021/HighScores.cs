using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Assignment_2021
{
    class HighScores
    {
        // Define the path to the high scores file
        public static string filePath = Application.StartupPath + @"\highScores.txt";

        // This method passes the username and time in seconds to add the high score to the file
        public static void addHighScore(string username, int time)
        {
            // Declare a stream writer object
            StreamWriter writer;

            // Define the stream writer object as opeing the high scores file and adding to it
            writer = File.AppendText(filePath);

            // Write a new line to the file with the username, then the time taken
            writer.WriteLine(username + "|" + time.ToString());

            // Close the file as the score has been added
            writer.Close();
        }

        // This method selects the top 10 lowest times (high scores) from the file and displays it
        public void displayHighScores()
        {
            // Declare the stream reader object
            StreamReader reader;

            reader = File.OpenText(filePath);
            // now define the reader as being able to open the highscores file defined by the path above

            // Declares a list containing a string for the username and an integer for the time
            List<(string, int)> highScoresList = new List<(string, int)>();

            // Defines variables that are populated later
            string line = "";
            string[] values;
            string username = "";
            int time = 0;

            // Loop through while not at the end of the file
            while (!reader.EndOfStream)
            {
                // Read a line from the text file
                line = reader.ReadLine();

                // Split the line after each '|' into an array
                values = line.Split('|');

                // Set the username to the first part of the array
                username = values[0];

                // Set the time to the second part of the array
                time = int.Parse(values[1]);

                // Add the username and time to the list
                highScoresList.Add((username, time));
            }

            // Close the file as all lines have been read
            reader.Close();

            // Sort the list by the 2nd item (time) ascending taking the smallest 10 times
            highScoresList = highScoresList.OrderBy(x => x.Item2).Take(10).ToList();

            // A counter variable
            int counter = 1;

            // For each item in the list
            foreach (var (displayUsername, displayTime) in highScoresList)
            {
                // Add a new row to the list box with the username and time in seconds
                ((Form7)Form7.ActiveForm).listBoxHighScores.Items.Add(counter.ToString() + ". " + displayUsername.PadRight(10) + "-".PadRight(10) + displayTime.ToString()); ;

                // Increase the counter by 1
                counter++;
            }
        }
    }
}