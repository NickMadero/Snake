using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Apple : gameObject
    {
        public int X {  get; set; }
        public int Y { get; set; }

        Random rand = new Random(); 
        public Apple() {
            
            // setting random values between 0-299 for the apple to spawn since this is how big our board is
            X = rand.Next(299);
            Y = rand.Next(299);
        }
    }
}
