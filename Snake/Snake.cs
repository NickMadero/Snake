using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Snake
{
    public class Snake : gameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        Direction direction; // enum direction 
        ArrayList snakeBody = new ArrayList();

        public Snake() {
            X = 100;
            Y = 100;
            Point head = new Point(X,Y); // head will always start here
            snakeBody.Add(head); // add the head to the arraylist

            direction = Direction.Right; // start the snake going to the right

            // for now just starting with a head.

        }


    }
}
