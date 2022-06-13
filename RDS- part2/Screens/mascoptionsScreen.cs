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
    public partial class mascoptionsScreen : UserControl
    {
        public mascoptionsScreen()
        {
            InitializeComponent();
        }

        private void johnnypickmeButton_Click(object sender, EventArgs e)
        {

        }

        private void charlespickmeButton_Click(object sender, EventArgs e)
        {
            hideall();
            femminineButton.Hide();
            premiumScreen prs = new premiumScreen();
            this.Controls.Add(prs);

            prs.Location = new Point((this.Width - prs.Width) / 2, (this.Height - prs.Height) / 2);
            prs.Focus();
        }

        private void femminineButton_Click(object sender, EventArgs e)
        {
            hideall();
            femoptionsScreen fem = new femoptionsScreen();
            this.Controls.Add(fem);

            fem.Location = new Point((this.Width - fem.Width) / 2, (this.Height - fem.Height) / 2);
            femminineButton.Hide();
        }

        public void hideall()
        {
            johnnyLabel.Hide();
            charlesLabel.Hide();
            johnnypickmeButton.Hide();
            charlespickmeButton.Hide();
            textoutput.Hide();
            nameOutput.Hide();
            fancylabel.Hide();
        }
    }
}
