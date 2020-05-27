using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_rarce_project_f
{
  public  class Better
    {
        
        
        public void player1setup(Label lbl,int dog , int betAmount,int budget1,Button btn) {
            if (betAmount <= budget1)
            {
                lbl.Text = "Simran-" + dog + "-" + betAmount;
                btn.Visible = true;
            }
            else {
                MessageBox.Show("You didn't have enough balance ");
            }
        }

        public void player2setup(Label lbl, int dog, int betAmount,int budget2, Button btn)
        {
            if (betAmount <= budget2)
            {
                lbl.Text = "Raman-" + dog + "-" + betAmount;
                btn.Visible = true;
            }
            else
            {
                MessageBox.Show("You didn't have enough balance ");
            }
        }

        public void player3setup(Label lbl, int dog, int betAmount, int budget3, Button btn)
        {
            if (betAmount <= budget3)
            {
                lbl.Text = "Gurman-" + dog + "-" + betAmount;
                btn.Visible = true;
            }
            else
            {
                MessageBox.Show("You didn't have enough balance ");
            }
        }



    }
}
