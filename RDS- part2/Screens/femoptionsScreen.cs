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
    public partial class femoptionsScreen : UserControl
    {
        public femoptionsScreen()
        {
            InitializeComponent();
        }

        private void bellapickmeButton_Click(object sender, EventArgs e)
        {
            hideall();
            masculineButton.Hide();
            bellagameScreen bgs = new bellagameScreen();
            this.Controls.Add(bgs);

            bgs.Location = new Point((this.Width - bgs.Width) / 2, (this.Height - bgs.Height) / 2);
            bgs.Focus();
        }
        private void bobbipickmeButton_Click(object sender, EventArgs e)
        {
            hideall();
            masculineButton.Hide();
            premiumScreen prs = new premiumScreen();
            this.Controls.Add(prs);

            prs.Location = new Point((this.Width - prs.Width) / 2, (this.Height - prs.Height) / 2);
            prs.Focus();
        }
        private void masculineButton_Click(object sender, EventArgs e)
        {
            hideall();
            mascoptionsScreen masc = new mascoptionsScreen();
            this.Controls.Add(masc);

            masc.Location = new Point((this.Width - masc.Width) / 2, (this.Height - masc.Height) / 2);
            masculineButton.Hide();
        }

        public void hideall()
        {
            bellaLabel.Hide();
            bobbiLabel.Hide();
            bellapickmeButton.Hide();
            bobbipickmeButton.Hide();
            textoutput.Hide();
            nameOutput.Hide();
            fancylabel.Hide();
        }

    }
}
