using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbigailSmith_CPT_185_Chapter_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picEight_Click(object sender, EventArgs e)
        {
            lblName.Text = "Eight of Diamonds";
        }

        private void picTwo_Click(object sender, EventArgs e)
        {
            lblName.Text = "Two of Clubs";
        }

        private void picKing_Click(object sender, EventArgs e)
        {
            lblName.Text = "King of Spades";
        }

        private void picAce_Click(object sender, EventArgs e)
        {
            lblName.Text = "Ace of Spades";
        }

        private void picJoker_Click(object sender, EventArgs e)
        {
            lblName.Text = "Joker";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.Text = "Click a card to see it's name!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
