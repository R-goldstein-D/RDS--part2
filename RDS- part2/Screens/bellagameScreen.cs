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
            hideoptions();
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
                else if (bellagame == 6) { bellagame = 7; }
                else if (bellagame == 7) { bellagame = 8; }
                else if (bellagame == 8) { bellagame = 9; }
                else if (bellagame == 9) { bellagame = 10; }
                else if (bellagame == 10) { bellagame = 11; }
                //bad ending 1 bella
                else if (bellagame == 12) { bellagame = 13; }
                else if (bellagame == 13) { bellagame = 14; }
                else if (bellagame == 14) { bellagame = 15; }
                else if (bellagame == 15) { bellagame = 16; }
                else if (bellagame == 16) { bellagame = 17; }
                else if (bellagame == 17) { bellagame = 18; }
                else if (bellagame == 18) { bellagame = 99; }
                //continue bella
                else if (bellagame == 19) { bellagame = 20; }
                else if (bellagame == 20) { bellagame = 21; }
                else if (bellagame == 21) { bellagame = 22; }
                else if (bellagame == 22) { bellagame = 23; }
                else if (bellagame == 23) { bellagame = 24; }
                //first score add or substract
                else if (bellagame == 25) { bellagame = 27; }
                else if (bellagame == 26) { bellagame = 27; }
                //continue texting 
                else if (bellagame == 27) { bellagame = 28; }

            }
            if (e.KeyCode == Keys.Right) //right arrow options 
            {
                //she asks for your #- no
                if (bellagame == 11) { bellagame = 12; }
                else if (bellagame == 24) { bellagame = 25; }

            }
            if (e.KeyCode == Keys.Left) //left arrow options 
            {
                //she asks for your #- yes
                if (bellagame == 11) { bellagame = 19; }
                else if (bellagame == 24) { bellagame = 26; }

            }

            switch (bellagame)
            {
                case 1:
                    textoutput.Text = "Press the space bar to continue";
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
                    textoutput.Text = "Oh thats no bother at all. I got  it from XXX, \nits a store thats juat by my house so its convient";
                    break;
                case 7:
                    belladesign();
                    textoutput.Text = "Ahh thats cool...wait XXX? Like the one opposite to the corner store?";
                    break;
                case 8:
                    playerdesign();
                    textoutput.Text = "Yeah! Woah I didn't realize you lived around that district too!";
                    break;
                case 9:
                    belladesign();
                    textoutput.Text = "Thats a nice coincidence, I know this might be too forward but it would be nice to keep in touch! \n" +
                        "I dont have many friends around here since I just moved in.";
                    break;
                case 10:
                    narratordesign();
                    textoutput.Text = "You are approcahing your first choice. Press the corresponding arrow keys to make your choice\n" +
                        "Pick your options wisely as they will affect you throught the route.";
                    break;
                case 11:
                    showoptions();
                    textoutput.Text = "She asks you for your ## to keep in touch\n" +
                        "Do you give it?";
                    leftOption.Text = "Yes";
                    rightOption.Text = "No";
                    break;
                case 12:
                    hideoptions();
                    narratordesign();
                    textoutput.Text = "Although looking dejected, the girl backs off and quietly walks back to her table\n" +
                        "Altough you felt a little bad";
                    break;
                case 13:
                    hideforscene();
                    //your house at night image
                    break;
                case 14:
                    showforscene();
                    narratordesign();
                    textoutput.Text = "You come home after a long day to find a note attached to your house\n" +
                        "Curious, you take a closer look";
                    break;
                case 15:
                    playerdesign();
                    textoutput.Text = "...";
                    break;
                case 16:
                    textoutput.Text = "Is that blood...?";
                    break;
                case 17:
                    narratordesign();
                    textoutput.Text = "You slowly open it to find that it was blood, & there was a note";
                    break;
                case 18:
                    XXXdesign();
                    textoutput.Text = "I TOOK CARE OF HER FOR YOU :)";
                    break;
                case 19:
                    belladesign();
                    hideoptions();
                    textoutput.Text = "Yay!";
                    break;
                case 20:
                    textoutput.Text = "I'll see your around then!";
                    break;
                case 21:
                    hideforscene();
                    //your house scene
                    break;
                case 22:
                    showforscene();
                    narratordesign();
                    textoutput.Text = "A few days had passed since your encounter with the mystery gil\n" +
                        "Your phone buzzed";
                    break;
                case 23:
                    nameOutput.Text = "+1 519-276-9762";
                    textoutput.Text = "Hey I'm not sure if you remember me or not...";
                    break;
                case 24:
                    showoptions();
                    textoutput.Text = "...but its the girl from the coffee shop!";
                    leftOption.Text = "Yeah I remember you";
                    rightOption.Text = "Who is this?";
                    break;
                case 25:
                    hideoptions();
                    belladesign();
                    bellaScore -= 1;
                    textoutput.Text = "No worries, its Bella";
                    break;
                case 26:
                    hideoptions();
                    belladesign();
                    bellaScore += 1;
                    textoutput.Text = "Yay, I'm glad then ^-^";
                    break;
                case 27:
                    textoutput.Text = "I hope you've been well";
                    break;
                case 28:
                    textoutput.Text = "I undertand this is out of the blue,\n" +
                        "but i have an extra ticket for the carnival that's in town";
                    break;
                case 29:
                    textoutput.Text = "Wanna come?";
                    break;
                case 30:
                    playerdesign();
                    textoutput.Text = "I mean I suppose so";
                    break;
                case 31:
                    textoutput.Text = "It's the one thats coming to town? I've been meaning to check it out anyway";
                    break;
                case 32:
                    belladesign();
                    textoutput.Text = "YESS thats the one\n" +
                        "I'll text you the details";
                    break;
                case 33:
                    hideforscene();
                    //carnival intro
                    break;
                case 34:
                    showforscene();
                    narratordesign();
                    textoutput.Text = "The carnival was bustling with life";
                    break;
                case 35:
                    textoutput.Text = "Brigt colours shined in your eyes as you squinted";
                    break;
                case 36:
                    break;
                case 37:
                    break;
                case 38:
                    break;
                case 39:
                    break;
                case 40:
                    break;
                case 41:
                    break;
                case 42:
                    break;
                case 99:
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
        public void XXXdesign()
        {
            nameOutput.Text = "";
            nameOutput.Text = "???";
            textoutput.BackColor = Color.Black;
            textoutput.ForeColor = Color.White;
            nameOutput.BackColor = Color.Black;
            nameOutput.ForeColor = Color.White;
            fancylabel.BackColor = Color.Black;
            fancylabel.ForeColor = Color.White;
        }

        public void hideoptions()
        {
            leftArrow.Hide();
            rightArrow.Hide();
            leftOption.Hide();
            rightOption.Hide();
        }
        public void showoptions()
        {
            leftArrow.Show();
            rightArrow.Show();
            leftOption.Show();
            rightOption.Show();
        }
        public void hideforscene()
        {
            textoutput.Hide();
            nameOutput.Hide();
            fancylabel.Hide();
        }
        public void showforscene()
        {
            textoutput.Show();
            nameOutput.Show();
            fancylabel.Show();
        }

    }
}
