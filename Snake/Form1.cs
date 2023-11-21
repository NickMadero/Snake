using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        // enum direction 
        Direction direction = new Direction();
        // creating the snake object
        Snake snake = new Snake();
        //creating the apple object
        Apple apple = new Apple();
        // creating the setting object
        Setting Setting = new Setting();
        

        public Form1()
        {
            InitializeComponent();
            // this should be placed here or it will be out of context. 
            gameTimer.Enabled = true; // this will  make the gameTimer_tick method start.
            gameTimer.Interval = 10;  // this is in 200 milliseconds. this will tick the event for that many millseconds
            direction = Direction.Right; // start the snake by going to the right

        }

        private void gameCanvas(object sender, PaintEventArgs e)
        {
            // have graphics object
            Graphics canavs = e.Graphics;

            if (Setting.GameOver == false)
            {

               
                // creating an apple brush
                Brush appleBrush = new SolidBrush(Color.Red);



                // drawing the apple 
                RectangleF appleRec = new RectangleF(apple.X, apple.Y, Setting.Width, Setting.Height);
                canavs.FillEllipse(appleBrush, appleRec);


                // creating an snake brush
                Brush snakebrush = new SolidBrush(Color.Black);



                // drawing the snake 
                RectangleF snakeRec = new RectangleF(snake.X, snake.Y, Setting.Width, Setting.Height);
                canavs.FillRectangle(snakebrush, snakeRec);

             

            }

        }

        private void movement(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (direction != Direction.Right)
                    {
                        direction = Direction.Left;
                    }
                    break;
                case Keys.Right:
                    if (direction != Direction.Left)
                    {
                        direction = Direction.Right;
                    }
                    break;
                case Keys.Up:
                    if (direction != Direction.Down)
                    {
                        direction = Direction.Up;
                    }
                    break;
                case Keys.Down:
                    if (direction != Direction.Up)
                    {
                        direction = Direction.Down;
                    }
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            switch (direction)
            {
                case Direction.Left:
                    snake.X = snake.X - 1;
                    if (snake.X  == this.ClientRectangle.Left ){
                        Application.Exit();
                    }
                    break;
                 
                case Direction.Right:

                    snake.X = snake.X + 1;
                    if (snake.X == this.ClientRectangle.Right - 55 )
                    {
                        Application.Exit();
                    }
                    break;
                case Direction.Up:
                    snake.Y = snake.Y - 1;
                    break;
                case Direction.Down:
                    snake.Y = snake.Y + 1;
                    break;
            }
            pictureBox1.Invalidate();
          
        }
    }
}
