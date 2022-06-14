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
    public partial class bellaminigameScreen : UserControl
    {
        //player button control keys - DO NOT CHANGE
        Boolean AArrowDown, DArrowDown, spaceBarDown;

        string gameState = "";

        int score = 3000;

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.PowderBlue);
        SolidBrush goodballBrush = new SolidBrush(Color.Plum);
        SolidBrush badballBrush = new SolidBrush(Color.White);
        public bellaminigameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set all button presses to false.
            AArrowDown = DArrowDown = false;


            StartGame();
        }

        public void StartGame()
        {
            if(spaceBarDown == true)
            {
                instructionsLabel.Hide();
                // start the game engine loop
                gameTimer.Enabled = true;
            }

        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {

        }

        private void bellaminigameScreen_Paint(object sender, PaintEventArgs e)
        {
            //update labels 
            scoreLabel.Text = $"Score: {score}";

            //draw player

            //draw ground

            //draw obsticals

            if (gameState == "pass")
            {
            }
            else if (gameState == "lose")
            {

            }
        }
    }

}

