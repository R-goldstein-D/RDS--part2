using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDS__part2
{
    public partial class bellagameScreen : UserControl
    {
        int bellagame = 0;
        public static int bellaScore = 5;

        public bellagameScreen()
        {
            InitializeComponent();
        }
        private void bellagameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Space) //continue 
            {
                if (bellagame == 0) { bellagame = 1; }
                else if (bellagame == 1) { bellagame = 2; }
                else if (bellagame == 2) { bellagame = 3; }
                else if (bellagame == 3) { bellagame = 4; }
                else if (bellagame == 4) { bellagame = 5; }
                else if (bellagame == 5) { bellagame = 6; }

            }

            switch (bellagame)
            {
                case 1:
                    textoutput.Text = "What unique choice";
                    break;
                case 2:
                    narratordesign();
                    textoutput.Text = "The coffee shop had a soft aesthetic, which might be why you always loved it there. ";
                    break;
                case 3:
                    textoutput.Text = "You sighed quietly as you took a sip of your pumpkin spice latte and stared at your computer screen";
                    break;
                case 4:
                    textoutput.Text = "Suddenly, a girl who you've never seen before approached your table.";
                    break;
                case 5:
                    belladesign();
                    textoutput.Text = "Hey! Sorry to bother you, but I was wondering where you got your laptop from?";
                    break;
                case 6:
                    playerdesign();
                    textoutput.Text = "Oh thats no bother at all. I got  it from XXX, its a store thats juat by my house so its convient";
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;

                default:
                    break;
            }
        }
        public void playerdesign()
        {
            nameOutput.Text = "";
            nameOutput.Text += introScreen.p.name;
            textoutput.BackColor = Color.PowderBlue;
            nameOutput.BackColor = Color.PowderBlue;
            fancylabel.BackColor = Color.PowderBlue;
        }
        public void narratordesign()
        {
            nameOutput.Text = "";
            nameOutput.Text = "Narrator";
            textoutput.BackColor = Color.LightCoral;
            nameOutput.BackColor = Color.LightCoral;
            fancylabel.BackColor = Color.LightCoral;
        }
        public void belladesign()
        {
            nameOutput.Text = "";
            nameOutput.Text = "Bella";
            textoutput.BackColor = Color.Plum;
            nameOutput.BackColor = Color.Plum;
            fancylabel.BackColor = Color.Plum;
        }

    }
}
