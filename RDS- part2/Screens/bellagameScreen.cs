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
using System.IO;
using System.Threading;
using System.Xml;

namespace RDS__part2
{
    public partial class bellagameScreen : UserControl
    {
        public static int bellagame = 0;
        public static int bellaScore = 5;

        //sounds
        SoundPlayer coffeeshop = new SoundPlayer(Properties.Resources.badending_piano);
        public bellagameScreen()
        {
            InitializeComponent();
            switchScene();
            hideoptions();
            letsplayButton.Hide();
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
                else if (bellagame == 28) { bellagame = 29; }
                else if (bellagame == 29) { bellagame = 30; }
                else if (bellagame == 30) { bellagame = 31; }
                else if (bellagame == 31) { bellagame = 32; }
                //carnival before game
                else if (bellagame == 32) { bellagame = 33; }
                else if (bellagame == 33) { bellagame = 34; }
                else if (bellagame == 34) { bellagame = 35; }
                else if (bellagame == 35) { bellagame = 36; }
                else if (bellagame == 36) { bellagame = 37; }
                else if (bellagame == 37) { bellagame = 38; }
                else if (bellagame == 38) { bellagame = 39; }
                else if (bellagame == 39) { bellagame = 40; }
                else if (bellagame == 40) { bellagame = 41; }
                else if (bellagame == 41) { bellagame = 42; }
                else if (bellagame == 42) { bellagame = 43; }
                else if (bellagame == 43) { bellagame = 44; }
                else if (bellagame == 44) { bellagame = 45; }
                //continue after minigame
                else if (bellagame == 46) { bellagame = 47; }
                else if (bellagame == 47) { bellagame = 48; }
                else if (bellagame == 48) { bellagame = 49; }
                else if (bellagame == 49) { bellagame = 50; }
                else if (bellagame == 50) { bellagame = 51; }
                else if (bellagame == 51) { bellagame = 52; }
                else if (bellagame == 52) { bellagame = 53; }
                else if (bellagame == 53) { bellagame = 54; }
                else if (bellagame == 54) { bellagame = 55; }
                else if (bellagame == 55) { bellagame = 56; }
                else if (bellagame == 56) { bellagame = 57; }
                else if (bellagame == 57) { bellagame = 58; }
                else if (bellagame == 58) { bellagame = 59; }
                else if (bellagame == 59) { bellagame = 60; }
                else if (bellagame == 60) { bellagame = 61; }
                else if (bellagame == 61) { bellagame = 62; }
                //after kiss or holding hands choice
                else if (bellagame == 63) { bellagame = 65; }
                else if (bellagame == 64) { bellagame = 65; }
                else if (bellagame == 65) { bellagame = 66; }
                else if (bellagame == 66) { bellagame = 67; }
            }
            if (e.KeyCode == Keys.Right) //right arrow options 
            {
                //she asks for your #- no
                if (bellagame == 11) { bellagame = 12; }
                else if (bellagame == 24) { bellagame = 25; }
                //hold hand
                else if (bellagame == 62) { bellagame = 64; }
            }
            if (e.KeyCode == Keys.Left) //left arrow options 
            {
                //she asks for your #- yes
                if (bellagame == 11) { bellagame = 19; }
                else if (bellagame == 24) { bellagame = 26; }
                //kiss
                else if (bellagame == 62) { bellagame = 63; }

            }
            switchScene();
        }
        public void switchScene()
        {

            switch (bellagame)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources.coffeeshopBG;
                    coffeeshop.Play();
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
                        "I dont have many friends around here since I just moved in.\n" +
                        "I'm Bella B. by the way!";
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
                    this.BackgroundImage = Properties.Resources.personalroomnightBG;
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
                    this.BackgroundImage = Properties.Resources.carnivalintroBG;
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
                    textoutput.Text = "The atmosphere was lively as families were laughing and having fun";
                    break;
                case 37:
                    textoutput.Text = "Someone tapped your shoulder";
                    break;
                case 38:
                    belladesign();
                    textoutput.Text = "Hey! I was looking for you!";
                    break;
                case 39:
                    playerdesign();
                    textoutput.Text = "Ah yeah same here...this place looks fun";
                    break;
                case 40:
                    belladesign();
                    textoutput.Text = "It does! I'm glad I'm not coming alone.";
                    break;
                case 41:
                    narratordesign();
                    textoutput.Text = "She interlocked your arms playfully and dragged you off";
                    break;
                case 42:
                    hideforscene();
                    this.BackgroundImage = Properties.Resources.carnivalboothsBG;
                    break;
                case 43:
                    showforscene();
                    belladesign();
                    textoutput.Text = "Lets play this one! C'mon!";
                    break;
                case 44:
                    playerdesign();
                    textoutput.Text = "I mean I guess so...";
                    break;
                case 45:
                    hideforscene();
                    letsplayButton.Show();
                    break;
                case 46:
                    showforscene();
                    this.BackgroundImage = Properties.Resources.carnivalboothsBG;
                    belladesign();
                    textoutput.Text = "That was so fun wasn't it??";
                    break;
                case 47:
                    playerdesign();
                    textoutput.Text = "Yeah! I think it was, sorry I was kinda hogging it";
                    break;
                case 48:
                    belladesign();
                    textoutput.Text = "I loved watching you play, you were so focused.";
                    break;
                case 49:
                    playerdesign();
                    textoutput.Text = "UGH! How can I not? It was weirdly difficult...";
                    break;
                case 50:
                    belladesign();
                    textoutput.Text = "...";
                    break;
                case 51:
                    playerdesign();
                    textoutput.Text = "What?";
                    break;
                case 52:
                    belladesign();
                    textoutput.Text = "Maybe you just suck.";
                    break;
                case 53:
                    playerdesign();
                    textoutput.Text = "OKAY, you know what-";
                    break;
                case 54:
                    narratordesign();
                    textoutput.Text = "You two bickered playfully until the bright lights of \n" +
                        "the ferris wheel came into view";
                    break;
                case 55:
                    this.BackgroundImage = Properties.Resources.carnivalferriswheeltopBG;
                    textoutput.Text = "The ferris wheel rocked a little as you both slowly stepped on.";
                    break;
                case 56:
                    belladesign();
                    textoutput.Text = "Why are you sitting accross from me? Sit by me so we can talk more comfortably.";
                    break;
                case 57:
                    playerdesign();
                    textoutput.Text = "Fair enough.";
                    break;
                case 58:
                    narratordesign();
                    textoutput.Text = "Although you moved to sit beside her, no conversation filled the atmosphere as you to sat in silence.";
                    break;
                case 59:
                    textoutput.Text = "You look over at Bella,\n" +
                        "She is staring outside in awe as she smiles gently";
                    break;
                case 60:
                    textoutput.Text = "Your face feels warm as you cannot stop staring";
                    break;
                case 61:
                    textoutput.Text = "She's quite pretty";
                    break;
                case 62:
                    showoptions();
                    textoutput.Text = "You panic as she looks at you";
                    leftOption.Text = "Kiss her";
                    rightOption.Text = "Hold her hand";
                    break;
                case 63:
                    hideoptions();
                    belladesign();
                    bellaScore -= 4;
                    textoutput.Text = "...";
                    break;
                case 64:
                    hideoptions();
                    narratordesign();
                    bellaScore += 4;
                    textoutput.Text = "Bella looked surpised but didnt say anything";
                    break;
                case 65:
                    narratordesign();
                    textoutput.Text = "You two sat in an overtaking silence as the beautiful view shined in the background.";
                    break;
                case 66:
                    textoutput.Text = "The ride slowly comes to a stop as you two stepped off";
                    break;
                case 67:
                    determineEnding();
                    break;
                case 99:
                    narratordesign();
                    textoutput.Text = "Thanks for playing!\n" +
                     "ending 2/6 unlocked";
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

        public void determineEnding()
        {
            //score less than or equal to 9- bad ending
            if (bellaScore <= 9)
            {
                bellabadendingScreen bbe = new bellabadendingScreen();
                this.Controls.Add(bbe);

                bbe.Location = new Point((this.Width - bbe.Width) / 2, (this.Height - bbe.Height) / 2);
                bbe.Focus();
            }
            //score grader than 9- good ending
            else if (bellaScore > 9)
            {
                bellagoodendingScreen bge = new bellagoodendingScreen();
                this.Controls.Add(bge);

                bge.Location = new Point((this.Width - bge.Width) / 2, (this.Height - bge.Height) / 2);
                bge.Focus();
            }
        }
        private void letsplayButton_Click(object sender, EventArgs e)
        {
            bellaminigameScreen bmgs = new bellaminigameScreen();
            this.Controls.Add(bmgs);

            bmgs.Location = new Point((this.Width - bmgs.Width) / 2, (this.Height - bmgs.Height) / 2);
            bmgs.Focus();
            letsplayButton.Hide();
        }
    }
}
