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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            introScreen ins = new introScreen();
            this.Controls.Add(ins);

            ins.Location = new Point((this.Width - ins.Width) / 2, (this.Height - ins.Height) / 2);
        }
    }
}
