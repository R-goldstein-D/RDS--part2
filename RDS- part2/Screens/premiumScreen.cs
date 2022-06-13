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
    public partial class premiumScreen : UserControl
    {
        public premiumScreen()
        {
            InitializeComponent();
        }

        private void startoverButton_Click(object sender, EventArgs e)
        {
            hideall();
            introScreen ins = new introScreen();
            this.Controls.Add(ins);

            ins.Location = new Point((this.Width - ins.Width) / 2, (this.Height - ins.Height) / 2);
        }
        private void getperimiumButton_Click(object sender, EventArgs e)
        {
            hideall();
            getpremiumScreencs gps = new getpremiumScreencs();
            this.Controls.Add(gps);

            gps.Location = new Point((this.Width - gps.Width) / 2, (this.Height - gps.Height) / 2);
            gps.Focus();
        }

        public void hideall()
        {
            textoutput.Hide();
            startoverButton.Hide();
            getperimiumButton.Hide();
        }

    }
}
