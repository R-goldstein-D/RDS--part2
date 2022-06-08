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
    public partial class introScreen : UserControl
    {
        int introscene = 0;
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
                else if (introscene == 2) { introscene = 3; }
                else if (introscene == 3) { introscene = 4; }
            }

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
            string name;
            name = nameInput.Text;

            p = new Player(name);
            playernames.Add(p);

            nameOutput.Text = "";
            nameOutput.Text += p.name;
            textoutput.Text = "Press the space bar to continue";

            hide();
            this.Focus();
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
