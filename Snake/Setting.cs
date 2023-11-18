using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Setting
    {
        public static int Width { get; set; } // set the width as int class
        public static int Height { get; set; } // set the height as int class
        public static bool GameOver { get; set; } // set the game over as Boolean class
        public static Direction direction { get; set; } // set the direction as the class we mentioned above


        public Setting()
        {
            // this is the default settings function
            Width = 16; // set the width to 16
            Height = 16; // set the height to 16
            GameOver = false; // set game over to false
            direction = Direction.Down; // the default direction will be down
        }


      

    }
}
