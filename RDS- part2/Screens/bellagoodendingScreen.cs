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
    public partial class bellagoodendingScreen : UserControl
    {
        int bellagoodscene = 0;
        public bellagoodendingScreen()
        {
            InitializeComponent();
        }

        private void bellagoodendingScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space) //continue 
            {
                if (bellagoodscene == 0) { bellagoodscene = 1; }
                else if (bellagoodscene == 1) { bellagoodscene = 2; }
                else if (bellagoodscene == 2) { bellagoodscene = 3; }
                else if (bellagoodscene == 3) { bellagoodscene = 4; }
                else if (bellagoodscene == 4) { bellagoodscene = 5; }
                else if (bellagoodscene == 5) { bellagoodscene = 6; }
                else if (bellagoodscene == 6) { bellagoodscene = 7; }
                else if (bellagoodscene == 7) { bellagoodscene = 8; }
                else if (bellagoodscene == 8) { bellagoodscene = 9; }
                else if (bellagoodscene == 9) { bellagoodscene = 99; }
            }
            switchScreen();
        }
        public void switchScreen()
        {

        }
    }
}
