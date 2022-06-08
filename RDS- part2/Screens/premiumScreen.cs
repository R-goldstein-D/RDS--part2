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

        public void hideall()
        {
            textoutput.Hide();
            startoverButton.Hide();
        }
    }
}
