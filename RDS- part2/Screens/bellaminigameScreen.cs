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
        //player button control keys
        Boolean leftArrowDown, rightArrowDown, spaceBarDown;

        string gameState = "";

        int score = 3000;

        int ballSize = 10;

        // Brushes
        SolidBrush playerBrush = new SolidBrush(Color.PowderBlue);
        SolidBrush goodballBrush = new SolidBrush(Color.Plum);
        SolidBrush badballBrush = new SolidBrush(Color.White);
        SolidBrush groundBrush = new SolidBrush(Color.Black);

        //ball properties
        List<int> ballXList = new List<int>();
        List<int> ballYList = new List<int>();
        List<int> ballSpeedList = new List<int>();
        List<string> ballColourList = new List<string>();
        Random randGen = new Random();
        int randValue = 0;

        public bellaminigameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set all button presses to false.
            leftArrowDown = rightArrowDown = spaceBarDown = false;

            ballXList.Clear();
            ballYList.Clear();
            ballSpeedList.Clear();

            introScreen.p.x = this.Width / 2 - introScreen.p.width / 2;
            introScreen.p.y = 360;
        }

        private void bellaminigameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Space && gameTimer.Enabled == false) //continue 
            {
                instructionsLabel.Hide();
                // start the game engine loop
                gameTimer.Enabled = true;
            }
            //move player during mini game
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
            }
        }

        private void bellaminigameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Move the playerd
            if (leftArrowDown && introScreen.p.x > 0)
            {
                introScreen.p.Move("left");
            }
            if (rightArrowDown && introScreen.p.x < (this.Width - introScreen.p.width))
            {
                introScreen.p.Move("right");
            }

            //check to see if a new ball should be created 
            randValue = randGen.Next(0, 51);

            if (randValue < 7) //6%  change  of  white  ball, (lose points) 
            {
                ballXList.Add(randGen.Next(10, this.Width - ballSize * 2));
                ballYList.Add(10);
                ballSpeedList.Add(randGen.Next(2, 10));
                ballColourList.Add("white");
            }
            else if (randValue >= 5 && randValue < 11) //4%  change  of  plum  ball, (get points) 
            {
                ballXList.Add(randGen.Next(10, this.Width - ballSize * 2));
                ballYList.Add(10);
                ballSpeedList.Add(randGen.Next(2, 10));
                ballColourList.Add("plum");

            }

            // move balls [create mesthid]
            for (int i = 0; i < ballXList.Count(); i++)
            {
                ballYList[i] += ballSpeedList[i];
            }

            //check if ball is below play area and remove it if it is 
            for (int i = 0; i < ballXList.Count(); i++)
            {
                if (ballYList[i] > 370)
                {
                    ballXList.RemoveAt(i);
                    ballYList.RemoveAt(i);
                    ballSpeedList.RemoveAt(i);
                    ballColourList.RemoveAt(i);
                    break;
                }
            }

            //check collision of ball and paddle [create meathod]
            Rectangle playerRec = new Rectangle(introScreen.p.x, introScreen.p.y, introScreen.p.width, introScreen.p.height);

            for (int i = 0; i < ballXList.Count(); i++)
            {
                Rectangle ballRec = new Rectangle(ballXList[i], ballYList[i], 10, 10);

                if (playerRec.IntersectsWith(ballRec))
                {
                    if (ballColourList[i] == "plum")
                    {
                        score += 100;
                    }
                    else if (ballColourList[i] == "white")
                    {
                        score -= 100;
                    }

                    ballXList.RemoveAt(i);
                    ballYList.RemoveAt(i);
                    ballSpeedList.RemoveAt(i);
                    ballColourList.RemoveAt(i);
                    break;
                }
            }
            //determine win or lose
            if (score == 5000)
            {
                gameState = "win";
            }
            else if (score == 2000)
            {
                gameState = "lose";
            }

            Refresh();
        }

        private void bellaminigameScreen_Paint(object sender, PaintEventArgs e)
        {
            if (gameTimer.Enabled == true)
            {
                //update labels 
                scoreLabel.Text = $"Score: {score}";

                //draw player
                e.Graphics.FillRectangle(playerBrush, introScreen.p.x, introScreen.p.y, introScreen.p.width, introScreen.p.height);

                //draw ground
                e.Graphics.FillRectangle(groundBrush, 0, 370, 2000, 50);

                //draw obsticals
                for (int i = 0; i < ballXList.Count(); i++)
                {
                    if (ballColourList[i] == "white")
                    {
                        e.Graphics.FillEllipse(badballBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                    }
                    else if (ballColourList[i] == "plum")
                    {
                        e.Graphics.FillEllipse(goodballBrush, ballXList[i], ballYList[i], ballSize, ballSize);
                    }
                }

                if (gameState == "win")
                {
                    //gamtimer stops
                    gameTimer.Enabled = false;
                    scoreLabel.Hide();
                    //+10 score
                    bellagameScreen.bellaScore += 10;
                    bellagameScreen.bellagame = 46;

                    //go back to game screen
                    bellagameScreen bgs = new bellagameScreen();
                    this.Controls.Add(bgs);

                    bgs.Location = new Point((this.Width - bgs.Width) / 2, (this.Height - bgs.Height) / 2);
                    bgs.Focus();
                }
                else if (gameState == "lose")
                {
                    //gametimer stops
                    gameTimer.Enabled = false;
                    scoreLabel.Hide();
                    //-3 score
                    bellagameScreen.bellaScore -= 3;
                    bellagameScreen.bellagame = 46;

                    //go back to game screen
                    bellagameScreen bgs = new bellagameScreen();
                    this.Controls.Add(bgs);

                    bgs.Location = new Point((this.Width - bgs.Width) / 2, (this.Height - bgs.Height) / 2);
                    bgs.Focus();
                }
            }
        }
    }

}

