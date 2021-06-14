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

        public Form1()
        {
            InitializeComponent();
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

        Random rand = new Random();

        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;

            int x = 66;
            int y = 66;
            int width = 66;
            int height = 66;
            int rowCount = 1;

            Graphics paper = panelGame.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 2);

            Font drawFont = new Font("Arial", 14);

            StringFormat drawFormat = new StringFormat();

            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;

            SolidBrush brush = new SolidBrush(Color.Black);

            string[] columnLetters = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            for (int row = 1; row <= 10; row++)
            {
                x = 0;
                paper.DrawRectangle(pen1, x, y, width, height);
                paper.DrawString(row.ToString(), drawFont, brush, (x + 40), (y + 26), drawFormat);

                x = 66;

                for (int column = 0; column < 10; column++)
                {
                    paper.DrawRectangle(pen1, x, y, width, height);
                    x += width;
                }

                y += height;
                x = 66;
            }

            y = 0;
            x = 66;

            for (int column = 1; column <= 10; column++)
            {
                paper.DrawRectangle(pen1, x, y, width, height);

                paper.DrawString(columnLetters[column-1], drawFont, brush, (x + 40), (y + 26), drawFormat);
                x += width;
            }

            //
            SolidBrush br = new SolidBrush(Color.Red);

            int[] shipDimensions = new int[] { 50, 55, 25, 35 };
            int shipX = 100;
            int shipY = 750;

            for (int ship = 0; ship < shipDimensions.Length; ship++)
            {
                
                paper.FillRectangle(br, shipX, shipY, shipDimensions[ship], shipDimensions[ship]);
                shipX += shipDimensions[ship] + 50;
            }
        }
    }
}
