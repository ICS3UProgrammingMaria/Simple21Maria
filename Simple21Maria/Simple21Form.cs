/*
 * Created by: Maria
 * Created on: 7-November-2018
 * Created for: ICS3U Programming
 * Assignment #5b - Simple 21
 * This program lets you play a simplified version of blackjack
*/
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
        int playercard1 = 0; int playercard2 = 0; int playercard3 = 0;
        int dealercard1 = 0; int dealercard2 = 0; int dealercard3 = 0;
        int playersubtotal = 0; int dealersubtotal = 0;
        const int MAX_VALUE = 10, MIN_VALUE = 1, START_MAX = 21, START_MIN = 4;

        //Random class
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
            dealercard1 = cards.Next(MIN_VALUE, MAX_VALUE + 1);

            //converts player cards to string
            lblPlayerCard1.Text = Convert.ToString(playercard1);
            lblPlayerCard2.Text = Convert.ToString(playercard2);
            lblDealerCard1.Text = Convert.ToString(dealercard1);

            playersubtotal = playercard1 + playercard2 + playercard3;
            dealersubtotal = dealercard1;
            lblplayersubtotal.Text = Convert.ToString(playersubtotal);
            lbldealersubtotal.Text = Convert.ToString(dealersubtotal);

        }


        //creates a main menu with a new game feature
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creates a new form 
            using (var form1 = new frmSimple21())
            {
                //shows new form and closes old
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
            lblPlayerCard3.Text = Convert.ToString(playercard3);
            playersubtotal = playercard1 + playercard2 + playercard3;
            lblplayersubtotal.Text = Convert.ToString(playersubtotal);
            dealersubtotal = dealercard1 + dealercard2 + dealercard3; 
        }
        
        private void btnStay_Click(object sender, EventArgs e)
        {
            //disables hit and stay buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //creates two new cards and generates values
            dealercard2 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            lblDealerCard2.Text = Convert.ToString(dealercard2);
            dealercard3 = cards.Next(MIN_VALUE, MAX_VALUE + 1);
            lblDealerCard3.Text = Convert.ToString(dealercard3);
            //Adds card values together 
            dealersubtotal = dealercard1 + dealercard2 + dealercard3;
            lbldealersubtotal.Text = Convert.ToString(dealersubtotal);

            //Win conditions
            if (dealersubtotal == playersubtotal)
            {
                lblDisplayOutcome.Text = "Dealer Wins";
            }
            else if (playersubtotal == 21)
            {
                //Changes the outcome label dependant on the winner
                lblDisplayOutcome.Text = "Player Wins";
            }
            else if (dealersubtotal == 21)
            {
                lblDisplayOutcome.Text = "Dealer Wins";
            }
            else if (playersubtotal > 21 )
            {
                lblDisplayOutcome.Text = "Bust: Dealer Wins";
            }
            else if (dealersubtotal > 21)
            {
                lblDisplayOutcome.Text = "Bust: Player Wins";
            }
            else if (dealersubtotal == playersubtotal)
            {
                lblDisplayOutcome.Text = "Dealer Wins";
            }
            else if (dealersubtotal > playersubtotal)
            {
                lblDisplayOutcome.Text = "Dealer wins";
            }
            else if (dealersubtotal < playersubtotal)
            {
                lblDisplayOutcome.Text = "Player wins";
            }
        }

        //Creates a main menu item used to exit the game
        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
