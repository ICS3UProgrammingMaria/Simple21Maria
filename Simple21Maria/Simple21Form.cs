using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple21Maria
{
    public partial class frmSimple21 : Form
    { 
        public frmSimple21()
        {
            InitializeComponent();
            lblDealerAnswer.Hide();
            lblDisplayOutcome.Hide();

        }
    
        //Declare global variables
        int player = 0; int dealer = 0; int playercard1 = 0; int playercard2 = 0; int playercard3 = 0; int playercard4 = 0; int playercard5 = 0;
        int playercard6 = 0; int dealercard1 = 0; int dealercard2 = 0; int dealercard3 = 0; int dealercard4; int dealercard5; int dealercard6;
        int totaldealer = 0; int totalplayer = 1; int subtotal = 0; int WIN = 21; int blackjack = 21;
        const int MAX_VALUE = 10, MIN_VALUE = 1, START_MAX = 21, START_MIN = 4;

        Random cards = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            //hides start button
            btnStart.Hide();

            //raandomly generstors and displays it
            playercard1 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            playercard2 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            dealer = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            subtotal = playercard1 + playercard2 + playercard3;


            lblPlayerCard1.Text = Convert.ToString(playercard1);
            lblDealerCard1.Text = Convert.ToString(dealer);

            lblDealerAnswer.Show();

            if (totaldealer == totalplayer)
            {
                lblDisplayOutcome.Text = "Dealer wins";
            }
            else if (totaldealer < blackjack)
            {
                lblDisplayOutcome.Text = "Dealer wins";
            }
            else if (totaldealer > totalplayer)
            {
                lblDisplayOutcome.Text = "Dealer wins";
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form1 = new frmSimple21())
            {
                Visible = false;
                form1.ShowDialog();
                Close();
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            player = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            totalplayer = playercard1 + playercard2;
            lblPlayerCard1.Text = Convert.ToString(player);

            //win conditions
            if (totalplayer == 21)
            {
                btnHit.Hide();
                lblDisplayOutcome.Text = "Player Wins";
                btnStay.Hide();
            }

        }
        
        private void btnStay_Click(object sender, EventArgs e)
        {
            if (totaldealer < 16)
            {
                dealer = cards.Next(MIN_VALUE, MAX_VALUE + 1);
                subtotal = playercard1 + playercard1 + playercard1;

                lblPlayerCard1.Text = Convert.ToString(playercard1);
                lblDealerCard1.Text = Convert.ToString(dealer);
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
