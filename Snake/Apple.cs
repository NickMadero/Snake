using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Snake
{
    internal class Apple : gameObject
    {
        public int X {  get; set; }
        public int Y { get; set; }
        Brush appleBrush = new SolidBrush(Color.Red);
        Random rand = new Random(); 
        public Apple() {
            
            // setting random values between 0-299 for the apple to spawn since this is how big our board is
            X = rand.Next(250);
            Y = rand.Next(250);
        }
        public void reDrawAppleOnCanvas(Graphics canvas ) {

                RectangleF appleRec = new RectangleF(X, Y, Setting.Width, Setting.Height);
                canvas.FillEllipse(appleBrush, appleRec);
          
        }
    }
}
