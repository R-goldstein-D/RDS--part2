using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace RDS__part2
{
    public partial class getpremiumScreencs : UserControl
    {
        public getpremiumScreencs()
        {
            InitializeComponent();
        }

        private void getpremiumScreencs_Load(object sender, EventArgs e)
        {
            Refresh();
            Thread.Sleep(10000);
            Application.Exit();
        }
    }
}
