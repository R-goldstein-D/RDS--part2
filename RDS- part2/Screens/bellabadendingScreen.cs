using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace RDS__part2
{
    public partial class bellabadendingScreen : UserControl
    {
        int bellabadscene = 0;
        SoundPlayer badEnding = new SoundPlayer(Properties.Resources.badending_piano);

        public bellabadendingScreen()
        {
            InitializeComponent();
        }

        private void bellabadendingScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            if (e.KeyCode == Keys.Space) //continue 
            {
                if (bellabadscene == 0) { bellabadscene = 1; }
                else if (bellabadscene == 1) { bellabadscene = 2; }
                else if (bellabadscene == 2) { bellabadscene = 3; }
                else if (bellabadscene == 3) { bellabadscene = 4; }
                else if (bellabadscene == 4) { bellabadscene = 5; }
                else if (bellabadscene == 5) { bellabadscene = 6; }
                else if (bellabadscene == 6) { bellabadscene = 7; }
                else if (bellabadscene == 7) { bellabadscene = 8; }
                else if (bellabadscene == 8) { bellabadscene = 9; }
                else if (bellabadscene == 9) { bellabadscene = 99; }
            }
            switchscreen();
        }

        public void switchscreen()
        {
            switch (bellabadscene)
            {
                case 1:
                    //house at night bg
                    narratordesign();
                    textoutput.Text = "You two walked home in silence after Bella hinted she wanted to leave";
                    break;
                case 2:
                    playerdesign();
                    textoutput.Text = "I had fun today, thank you for inviting me!";
                    break;
                case 3:
                    belladesign();
                    textoutput.Text = "Yeah no problem.";
                    break;
                case 4:
                    playerdesign();
                    textoutput.Text = "I was also wondering if you wanted to do this again sometime?";
                    break;
                case 5:
                    belladesign();
                    textoutput.Text = "Uhhh....";
                    break;
                case 6:
                    textoutput.Text = "I'll think about it I suppose.";
                    break;
                case 7:
                    narratordesign();
                    textoutput.Text = "She checks her watch";
                    break;
                case 8:
                    belladesign();
                    textoutput.Text = "I have to go, thanks for dropping me off, also don't text me for a while.\n" +
                        "I'll be busy with um school yeah";
                    break;
                case 9:
                    playerdesign();
                    textoutput.Text = "Didn't you mention you were 32...?";
                    break;
                case 99:
                    badEnding.Play();
                    narratordesign();
                    textoutput.Text = "Thanks for playing!\n" +
                        "ending 3/6 unlocked";
                    Refresh();
                    Thread.Sleep(4000);
                    Application.Exit();
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
