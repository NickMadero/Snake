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
        List<Point> body = new List<Point>();
        Setting Setting = new Setting();
        Brush snakeBrush = new SolidBrush(Color.Green);
        public Snake() {
            X = 100;
            Y = 100;
            body.Add(new Point(100, 100));
            body.Add(new Point(100, 101));
            body.Add(new Point(100, 102));
        }

        public void MoveSnake(int newX, int newY)
        {
            // Logic to move the snake's head to newX, newY and update the body accordingly
            // This could involve removing the last point and adding a new point at the head's position
            body.RemoveAt(body.Count - 1); // Remove the tail
            body.Insert(0, new Point(newX, newY)); // Insert a new head position
        }

        public void RedrawSnakeOnCanvas(Graphics canvas)
        {
            // Assuming you have a Graphics object to draw on
            for (int i = 0; i < body.Count; i++)
            {
                // Draw circular body parts for the snake
                RectangleF bodyPart = new RectangleF(body[i].X, body[i].Y, Setting.Width, Setting.Height);
                canvas.FillEllipse(snakeBrush, bodyPart);
            }
        }

    }
}
