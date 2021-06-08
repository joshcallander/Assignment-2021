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

            int x = 0;
            int y = 0;
            int width = 65;
            int height = 65;

            Graphics paper = panelGame.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 2);

            for (int row = 0; row < 8; row++)
            {
                for (int column = 0; column < 8; column++)
                {
                    paper.DrawRectangle(pen1, x, y, width, height);
                    x += width;
                }

                y += height;
                x = 0;
            }
            //
            SolidBrush br = new SolidBrush(Color.Red);

            int[] shipDimensions = new int[] { 50, 55, 25, 35 };
            int shipX = 100;
            int shipY = 550;

            for (int ship = 0; ship < shipDimensions.Length; ship++)
            {
                Rectangle shipRectangle[ship] = new Rectangle();
                paper.FillRectangle(br, shipX, shipY, shipDimensions[ship], shipDimensions[ship]);
                shipX += shipDimensions[ship] + 50;

                rect.X = e.X - MouseDownLocation.X;
            }
        }
    }
}
