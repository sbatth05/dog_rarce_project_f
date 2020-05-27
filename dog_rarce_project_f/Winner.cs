using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dog_rarce_project_f
{
   public class Winner
    {

        public int player1(Label lbl,int winner,int budget) {
                String[] data = lbl.Text.Split('-');
                int dog = Convert.ToInt32(data[1]);
                int amount = Convert.ToInt32(data[2]);
                if (dog == winner)
                {
                lbl.Text = "Simran has " + (budget + amount);
                    return budget + amount;
                }
                else
                {
                    lbl.Text = "Simran has " + (budget - amount);
                    return budget - amount;
                }
        }

        public int player2(Label lbl, int winner, int budget)
        {
            String[] data = lbl.Text.Split('-');
            int dog = Convert.ToInt32(data[1]);
            int amount = Convert.ToInt32(data[2]);
            if (dog == winner)
            {
                lbl.Text = "Raman has " + (budget + amount);
                return budget + amount;
            }
            else
            {
                lbl.Text = "Raman has " + (budget - amount);
                return budget - amount;
            }
        }


        public int player3(Label lbl, int winner, int budget)
        {
            String[] data = lbl.Text.Split('-');
            int dog = Convert.ToInt32(data[1]);
            int amount = Convert.ToInt32(data[2]);
            if (dog == winner)
            {
                lbl.Text = "Gurman has " + (budget + amount);
                return budget + amount;
            }
            else
            {
                lbl.Text = "Gurman has " + (budget - amount);
                return budget - amount;
            }
        }








    }
}
