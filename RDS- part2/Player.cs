using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDS__part2
{
    public class Player
    {
        public string name;
        public int x = 596;
        public int y = 51;
        public int width = 100;
        public int height = 10;
        public int speed = 20;

        public Player(string _name)
        {
            name = _name;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }
            if (direction == "right")
            {
                x += speed;
            }
        }
    }
}
