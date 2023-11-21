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

        public Snake() {
            X = 100;
            Y = 100;
        }


    }
}
