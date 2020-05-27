using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_rarce_project_f
{
    public partial class Form1 : Form
    {
        int player1 = 0,player2=0,player3=0;

        int dog1 = 0,winner=0;

        int budget1 = 120, budget2 = 150, budget3 = 180;

        Random rd = new Random();
        
        Better obj_Better = new Better();


        private void sldog1_CheckedChanged(object sender, EventArgs e)
        {
            if (sldog1.Checked==true) {
                dog1 = 1;
            }
            
        }

        private void sldog2_CheckedChanged(object sender, EventArgs e)
        {
            dog1 = 2;
        }

        private void sldog3_CheckedChanged(object sender, EventArgs e)
        {
            dog1 = 3;
        }

        private void sldog4_CheckedChanged(object sender, EventArgs e)
        {
            dog1 = 4;
        }

        public void resetAll() {

            pl_gurman.Checked = false;
            pl_simran.Checked = false;
            pl_raman.Checked = false;
            sldog1.Checked = false;
            sldog2.Checked = false;
            sldog3.Checked = false;
            sldog4.Checked = false;
            player1 = 0;
            player2 = 0;
            player3 = 0;
            dog1 = 0;
            entramount.Value = 1;

        }
        private void betsetbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(""+dog1);

            //when the player want to set the bet for the competition then first of all must have to choose the player, dog and bet amount 
            // if the applied the all condition only then he can start the race
            if (player1 == 1 && dog1 > 0)
            {
                obj_Better.player1setup(lbl_Simran, dog1, Convert.ToInt32(entramount.Value),budget1,stracebtn);
                
            }
            else if (player2 == 1 && dog1 > 0)
            {
                obj_Better.player2setup(lbl_Raman, dog1, Convert.ToInt32(entramount.Value),budget2, stracebtn);
                
            }
            else if (player3 == 1 && dog1 > 0)
            {
                obj_Better.player3setup(lbl_Ghuman, dog1, Convert.ToInt32(entramount.Value),budget3, stracebtn);
                
            }
            else {
                MessageBox.Show("must select a player and dog for the bet ");
            }

            resetAll();
            
        }

        public void resultDeclare() {
            if (lbl_Simran.Text.Contains("-")) {
                budget1 = new Winner().player1(lbl_Simran,winner,budget1);
            }

            if (lbl_Raman.Text.Contains("-"))
            {
                budget2 = new Winner().player1(lbl_Raman, winner, budget2);
            }

            if (lbl_Ghuman.Text.Contains("-"))
            {
                budget3 = new Winner().player1(lbl_Ghuman, winner, budget3);
            }

            pictureDog1.Left = 0;
            pictureDog2.Left = 0;
            pictureDog3.Left = 0;
            pictureDog4.Left = 0;
            stracebtn.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureDog1.Left += rd.Next(1,30);
            pictureDog2.Left += rd.Next(1, 30);
            pictureDog3.Left += rd.Next(1, 30);
            pictureDog4.Left += rd.Next(1, 30);

            if (pictureDog1.Left > new Ground().endPoint())
            {
                timer1.Enabled = false;
                winner = 1;
                MessageBox.Show("dog 1 winner");
                resultDeclare();
            }
            else if (pictureDog2.Left > new Ground().endPoint())
            {
                timer1.Enabled = false;
                winner = 2;
                MessageBox.Show("dog 2 winner");
                resultDeclare();
            }
            else if (pictureDog3.Left > new Ground().endPoint())
            {
                timer1.Enabled = false;
                winner = 3;
                MessageBox.Show("dog 3 winner");
                resultDeclare();
            }

            else if (pictureDog4.Left>new Ground().endPoint()) {
                timer1.Enabled = false;
                winner = 4;
                MessageBox.Show("dog 4 winner");
                resultDeclare();
            }

            //stracebtn.Text = "" + pictureDog4.Left;
            
        }

        private void stracebtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }

        private void pl_gurman_CheckedChanged(object sender, EventArgs e)
        {
            //check that the player is choosed or not 
            if (pl_gurman.Checked== true)
            {
                player3 = 1;
            }
            else
            {

            }
        }

        private void pl_raman_CheckedChanged(object sender, EventArgs e)
        {
            //check that the player is choosed or not 
            if (pl_raman.Checked == true)
            {
                player2 = 1;
            }
            else
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pl_simran_CheckedChanged(object sender, EventArgs e)
        {
            //check that the player is choosed or not 
            if (pl_simran.Checked==true) {
                player1 = 1;
            }
            else {
                    
            }
        }
    }
}
