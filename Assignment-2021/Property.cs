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
    class Property
    {
        // The number of properties
        public static int numberOfProperties = 40;

        // Declare an array of properties
        public static generateProperty[] Properties = new generateProperty[numberOfProperties];

        public static Graphics paper = ((Form4)Form4.ActiveForm).panelGame.CreateGraphics();
        public static Pen pen = new Pen(Color.Black, 2);

        public static Rectangle[] tile = new Rectangle[numberOfProperties];

        // The generateProperty class with the variables
        public class generateProperty
        {
            public int Owner;
            public int value;
            public string colour;
            public bool owned = false;
            public string Name;
            public int rent;
            public bool buyable;
        }

        // The RegisterProperty method
        public void RegisterProperty(string Name, bool buyable, string colour, int value, int location, int x, int y, int width, int height)
        {
            generateProperty temp = new generateProperty();

            // Set the values of the array to the values passed to the method
            temp.Name = Name;
            temp.colour = colour;
            temp.buyable = buyable;
            temp.value = value;
            Properties[location] = temp;

            tile[location] = paper.DrawRectangle(pen, x, y, width, height);
        }
        
        // The PropertiestoString method
        public string PropertiestoString(int[] propertyList)
        {
            // A string to be added to
            string tempString = "";

            // Loop through each property
            for (int i = 0; i < numberOfProperties; i++)
            {
                // If the list of properties owned is not equal to 0
                if (propertyList[i] != 0)
                {
                    // Add the property name and colour to the string
                    tempString += Properties[propertyList[i]].Name + ", " + Properties[propertyList[i]].colour + "\n"; //looping through properties the player owns and getting the name of each add new line so it can be read easily
                }
            }

            // Return the string to the method
            return tempString;
        }
    }
}
