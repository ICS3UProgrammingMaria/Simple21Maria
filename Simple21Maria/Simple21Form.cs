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
    { //lblAnswer.Hide();
        public frmSimple21()
        {
            InitializeComponent();
           

        }

        //Declare global variables
        int player = 0; int dealer = 0; int totaldealer; int totalplayer = 1;
        const int MAX_VALUE = 10, MIN_VALUE = 1;


        Random cards = new Random();



        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Hide();


            player = cards.Next(MAX_VALUE, MIN_VALUE + 1) * 2;
            dealer = cards.Next(MAX_VALUE, MIN_VALUE + 1);

            lblPlayerAnswer.Text = Convert.ToString(player);
           lblDealerAnswer.Text = Convert.ToString(dealer);


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

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
