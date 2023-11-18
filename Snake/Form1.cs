using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        Direction direction = new Direction();
        // creating the snake object
        Snake snake = new Snake();
        //creating the apple object
        Apple apple = new Apple();

        public Form1()
        {
            InitializeComponent();
            gameTimer.Enabled = true;
            gameTimer.Interval = 200; 

            Setting Setting = new Setting();

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
                    snake.X = snake.X - 10;
                    break;
                case Direction.Right:
                    snake.X = snake.X + 10;
                    break;
                case Direction.Up:
                    snake.Y = snake.Y - 10;
                    break;
                case Direction.Down:
                    snake.Y = snake.Y + 10;
                    break;
            }
            pictureBox1.Invalidate();
          
        }
    }
}
