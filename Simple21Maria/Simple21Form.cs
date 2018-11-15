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
            btnHit.Hide();
            btnStay.Hide();
        }
    
        //Declare global variables
        int player = 0;  int playercard1 = 0; int playercard2 = 0; int playercard3 = 0;
        int dealer = 0; int dealercard1 = 0; int dealercard2 = 0; int dealercard3 = 0;
        int totaldealer = 0; int totalplayer = 0; int playersubtotal = 0; int dealersubtotal = 0;  int WIN = 21; 
        const int MAX_VALUE = 10, MIN_VALUE = 1, START_MAX = 21, START_MIN = 4;

        Random cards = new Random();

        private void btnStart_Click(object sender, EventArgs e)
        {
            //hides and shows needed items
            btnStart.Hide();
            btnHit.Show();
            btnStay.Show();
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            //raandomly generates and displays card numbers
            playercard1 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            playercard2 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            dealer = cards.Next(MIN_VALUE, MAX_VALUE + 1);

            lblPlayerCard1.Text = Convert.ToString(playercard1);
            lblPlayerCard2.Text = Convert.ToString(playercard2);
            lblDealerCard1.Text = Convert.ToString(dealer);

            playersubtotal = playercard1 + playercard2 + playercard3;
            dealersubtotal = dealercard1;
            lblplayersubtotal.Text = Convert.ToString(playersubtotal);

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
            //hides and shows needed items
            btnHit.Enabled = false;

            playercard3 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            totalplayer = playersubtotal;
            lblplayersubtotal.Text = Convert.ToString(playersubtotal);
            playersubtotal = playercard1 + playercard2 + playercard3;
            lblPlayerCard3.Text = Convert.ToString(playercard3);
            
        }
        
        private void btnStay_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false;
            btnStay.Enabled = false;
            if (totaldealer < 16)
            {
                dealercard2 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
                dealercard3 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
                playersubtotal = playercard1 + playercard2 + playercard3;
                dealersubtotal = dealercard1 + dealercard2 + dealercard3;

                lblPlayerCard1.Text = Convert.ToString(playercard1);
                lblDealerCard2.Text = Convert.ToString(dealercard2);
                lblDealerCard3.Text = Convert.ToString(dealercard3);
                lblplayersubtotal.Text = Convert.ToString(playersubtotal);
                lbldealersubtotal.Text = Convert.ToString(dealersubtotal);
            }
            if (totaldealer == totalplayer)
            {
                btnHit.Hide();
                lblDisplayOutcome.Text = "Dealer Wins";
                btnStay.Hide();

                //Win conditions
                if (totalplayer == 21)
                {
                    btnHit.Hide();
                    lblDisplayOutcome.Text = "Player Wins";
                    btnStay.Hide();
                }
                if (totalplayer < WIN)
                {
                    lblDisplayOutcome.Text = "Dealer Wins";
                }
                if (totaldealer == totalplayer)
                {
                    btnHit.Hide();
                    lblDisplayOutcome.Text = "Dealer Wins";
                    btnStay.Hide();
                }
                else if (totaldealer < WIN)
                {
                    lblDisplayOutcome.Text = "Player wins";
                }
                else if (totaldealer > totalplayer)
                {
                    lblDisplayOutcome.Text = "Dealer wins";
                }
            }
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
