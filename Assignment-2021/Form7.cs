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
    public partial class Form7 : Form
    {
        // The HighScores class
        private HighScores HighScores = new HighScores();

        public Form7()
        {
            InitializeComponent();
        }

        // Onload of the form call the displayHighScores method in the HighScores class
        private void Form7_Load(object sender, EventArgs e)
        {
            HighScores.displayHighScores();
        }

        // Onclick of the Back button show the opening form and hide the current form
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
