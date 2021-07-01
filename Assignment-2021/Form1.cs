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
        string username = "";
        List<Rectangle> rectList = new List<Rectangle>();

        Random rand = new Random();

        // can have modes for easy, moderate and hard that changes the grid size
        
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            UpdateStyles();
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string[] columnLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "I", "J", "I", "J" };

        bool isMouseDown = false;

        int shipX = 20;
        int shipY = 750;

        int gridSize = 0;

        private int CalculateWidth(string startLetter, string endLetter)
        {
            int startLetterValue = 0;
            int endLetterValue = 0;

            for (int i = 0; i < columnLetters.Length; i++)
            {
                if (startLetter == columnLetters[i])
                {
                    startLetterValue = i;
                }

                if (endLetter == columnLetters[i])
                {
                    endLetterValue = i;
                }
            }

            return ((endLetterValue - startLetterValue + 1) * 50);
        }

        private int CalculateHeight(int startNumber, int endNumber)
        {
            int startNumberValue = 0;
            int endNumberValue = 0;

            for (int i = 0; i < gridSize; i++)
            {
                if (startNumber == i)
                {
                    startNumberValue = i;
                }

                if (endNumber == i)
                {
                    endNumberValue = i;
                }
            }

            return ((endNumberValue - startNumberValue + 1) * 50);
        }

        int mouseDownX = 0;
        int mouseDownY = 0;

        private void panelGame_MouseUp(object sender, MouseEventArgs e)
        {
            for (int row = 1; row <= gridSize; row++)
            {
                for (int column = 1; column <= gridSize; column++)
                {
                    for (int i = 0; i < rectList.Count; i++)
                    {
                        var targetingRectangle = rectList[i];

                        if (mouseDownX >= targetingRectangle.X && mouseDownX <= targetingRectangle.X + targetingRectangle.Width && mouseDownY >= targetingRectangle.Y && mouseDownY <= targetingRectangle.Y + targetingRectangle.Height)
                        {
                            if (targetingRectangle.Y >= ((row * 66)) && targetingRectangle.Y <= ((row * 66) + 66) && targetingRectangle.X >= ((column * 66)) && targetingRectangle.X <= ((column * 66) + 66))
                            {
                                isMouseDown = false;
                                rectList.RemoveAt(i);
                                rectList.Insert(i, new Rectangle(((66 * column) + 11), ((66 * row) + 11), targetingRectangle.Width, targetingRectangle.Height));
                                Refresh();
                                mouseDownX = e.X;
                                mouseDownY = e.Y;
                            }
                        }
                    }
                }
            }
        }

        List<string> potentialPositions = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };



        private void GenerateAIShips()
        {
            string[] shipDimensionsLetter = new string[] { "A", "B", "D", "D", "G", "J", "A", "A", "J", "J", "E", "J" };
            int[] shipDimensionsNumber = new int[] { 1, 1, 1, 3, 1, 1, 3, 6, 3, 4, 6, 6 };

            for (int ship = 0; ship < shipDimensionsLetter.Length; ship += 2)
            {
                int aiX = rand.Next(panelGame.Width);
                int aiY = rand.Next(panelGame.Height);

                if (aiX == 0)
                {

                }

                rectList.Add(new Rectangle(aiX, aiY, CalculateWidth(shipDimensionsLetter[ship], shipDimensionsLetter[ship + 1]), CalculateHeight(shipDimensionsNumber[ship], shipDimensionsNumber[ship + 1])));

                if (isMouseDown == false)
                {
                    shipX += CalculateWidth(shipDimensionsLetter[ship], shipDimensionsLetter[ship + 1]) + 44;
                }
            }

            Refresh();
        }

        private void panelGame_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                for (int i = 0; i < rectList.Count; i++)
                {
                    var targetingRectangle = rectList[i];

                    if (mouseDownX >= targetingRectangle.X && mouseDownX <= targetingRectangle.X + targetingRectangle.Width && mouseDownY >= targetingRectangle.Y && mouseDownY <= targetingRectangle.Y + targetingRectangle.Height)
                    {
                        rectList.RemoveAt(i);
                        rectList.Insert(i, new Rectangle(targetingRectangle.X + e.X - mouseDownX, targetingRectangle.Y + e.Y - mouseDownY, targetingRectangle.Width, targetingRectangle.Height));
                    }
                }

                //if (targetingRectangle.Right > panelGame.Width)
                //{
                //    targetingRectangle.X = panelGame.Width - rectList[i].Width;
                //}

                //if (targetingRectangle.Top < 0)
                //{
                //    targetingRectangle.Y = 0;
                //}

                //if (targetingRectangle.Left < 0)
                //{
                //    targetingRectangle.X = 0;
                //}

                //if (targetingRectangle.Bottom > panelGame.Height)
                //{
                //    targetingRectangle.Y = panelGame.Height - rectList[i].Height;
                //}

                mouseDownX = e.X;
                mouseDownY = e.Y;

                Refresh();
            }
        }

        private void panelGame_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            mouseDownX = e.X;
            mouseDownY = e.Y;
        }

        Pen pen1 = new Pen(Color.Black, 2);
        SolidBrush brush = new SolidBrush(Color.Black);

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(Color.Black);

            for (int i = 0; i < rectList.Count; i++)
            {
                e.Graphics.FillRectangle(brush, rectList[i]);
            }

            int x = 66;
            int y = 66;
            int width = 66;
            int height = 66;

            Font drawFont = new Font("Arial", 14);

            StringFormat drawFormat = new StringFormat();

            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            for (int row = 1; row <= gridSize; row++)
            {
                e.Graphics.DrawRectangle(pen1, 0, y, width, height);
                e.Graphics.DrawString(row.ToString(), drawFont, brush, 40, (y + 26), drawFormat);

                for (int column = 0; column < gridSize; column++)
                {
                    e.Graphics.DrawRectangle(pen1, x, y, width, height);
                    x += width;
                }

                y += height;
                x = 66;
            }

            y = 0;

            for (int column = 1; column <= gridSize; column++)
            {
                e.Graphics.DrawRectangle(pen1, x, y, width, height);
                e.Graphics.DrawString(columnLetters[column - 1], drawFont, brush, (x + 40), (y + 26), drawFormat);

                x += width;
            } 
        }

        private void refreshGame()
        {
            shipX = 20;
            shipY = 750;

            string[] shipDimensionsLetter = new string[] { "A", "B", "D", "D", "G", "J", "A", "A", "J", "J", "E", "J" };
            int[] shipDimensionsNumber = new int[] { 1, 1, 1, 3, 1, 1, 3, 6, 3, 4, 6, 6 };

            for (int ship = 0; ship < shipDimensionsLetter.Length; ship += 2)
            {
                rectList.Add(new Rectangle(shipX, shipY, CalculateWidth(shipDimensionsLetter[ship], shipDimensionsLetter[ship + 1]), CalculateHeight(shipDimensionsNumber[ship], shipDimensionsNumber[ship + 1])));

                if (isMouseDown == false)
                {
                    shipX += CalculateWidth(shipDimensionsLetter[ship], shipDimensionsLetter[ship + 1]) + 44;
                }
            }

            Refresh();
        }

        private void buttonEasy_Click(object sender, EventArgs e)
        {
            gridSize = 8;
            refreshGame();
        }

        private void buttonMedium_Click(object sender, EventArgs e)
        {
            gridSize = 10;
            refreshGame();
        }

        private void buttonHard_Click(object sender, EventArgs e)
        {
            gridSize = 12;
            refreshGame();
        }
    }
}
