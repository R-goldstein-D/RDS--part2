using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RDS__part2
{
    public partial class introScreen : UserControl
    {
        public static int introscene = 0;
        List<Player> playernames = new List<Player>();
        public static Player p;

        public introScreen()
        {
            InitializeComponent();
            hide();
        }

        private void introScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //continue 
            {
                if (introscene == 0) { introscene = 1; }
                else if (introscene == 1) { introscene = 2; }
                else if (introscene == 3) { introscene = 4; }
            }
            switchScreen();
        }

        public void switchScreen()
        {
            switch (introscene)
            {
                case 0:
                    nameOutput.Text = "Ria";
                    textoutput.Text = "Welcome to RDS; part II..ready for your adventure? Click the spacebar to continue";
                    break;
                case 1:
                    textoutput.Text = "If you aren't, you're gonna be :)";
                    break;
                case 2:
                    textoutput.Text = "Enter a name for youself!";
                    nameInput.Show();
                    okButton.Show();
                    break;
                case 3:
                    hide();
                    playerdesign();
                    textoutput.Text = "Alright...";
                    break;
                case 4:
                    textoutput.Text = "What do I do now?";
                    mascButton.Show();
                    femButton.Show();
                    break;
                default:
                    break;
            }
        }

        public void hide()
        {
            nameInput.Hide();
            okButton.Hide();
            mascButton.Hide();
            femButton.Hide();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            loadName();

            nameOutput.Text = "";
            nameOutput.Text += p.name;

            introscene = 3;
            switchScreen();
            hide();
            this.Focus();
        }

        public void loadName()
        {
            if (nameInput.Text == "")
            {
                XmlReader reader = XmlReader.Create("Player.xml");
                int nameValue = 1;

                while(reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        playernames.Add(new Player(reader.ReadString()));
                        nameValue++;
                        reader.ReadToNextSibling("name"+nameValue);
                    }
                }

                Random randName= new Random();
                nameValue = randName.Next(0, playernames.Count - 1);

                p = playernames[nameValue];

            }
            else
            {
                string name;
                name = nameInput.Text;

                p = new Player(name);
                playernames.Add(p);
            }
        }
        public void playerdesign()
        {
            textoutput.BackColor = Color.PowderBlue;
            nameOutput.BackColor = Color.PowderBlue;
            fancylabel.BackColor = Color.PowderBlue;
        }

        private void mascButton_Click(object sender, EventArgs e)
        {
            hide();
            textoutput.Hide();
            nameOutput.Hide();
            fancylabel.Hide();

            mascoptionsScreen masc = new mascoptionsScreen();
            this.Controls.Add(masc);

            masc.Location = new Point((this.Width - masc.Width) / 2, (this.Height - masc.Height) / 2);
        }

        private void femButton_Click(object sender, EventArgs e)
        {
            hide();
            textoutput.Hide();
            nameOutput.Hide();
            fancylabel.Hide();

            femoptionsScreen fem = new femoptionsScreen();
            this.Controls.Add(fem);

            fem.Location = new Point((this.Width - fem.Width) / 2, (this.Height - fem.Height) / 2);
        }
    }
}
