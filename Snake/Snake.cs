using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    public class Snake
    {

        private List<Cell> Body = new List<Cell>();

        public enum direction { Down, Up, Left, Right};

        public  int Width { get; set; }
        public  int Height { get; set; }
        public  int Speed { get; set; }
        public  int Score { get; set; }
        public  int X { get; set; }
        public  int Y { get; set; }
        public static int Step { get; set; }


        public static bool isDead { get; set; }
        
        public direction Direction {get; set;}

        public static Brush SnakeColor { get; set; }

        public Snake()
        {
            isDead = false;
            Width = 10;
            Height = 10;
            Speed = 10;
            Score = 0;
            X = 10;
            Y = 10;
            Direction = direction.Right;
            Step = 1;
            SnakeColor = new SolidBrush(Color.LawnGreen);

        }

        public void CreateBody()
        {

            Cell c1 = new Cell(this.X, this.Y);
            Cell c2 = new Cell(this.X, this.Y);
            Cell c3 = new Cell(this.X, this.Y); 

            Body[0] = c1;

        }


        public void ResetDefaults()
        {

            isDead = false;
            Width = 10;
            Height = 10;
            Speed = 10;
            Score = 0;
            X = 10;
            Y = 10;
            Direction = direction.Right;
            Step = 1;
            SnakeColor = new SolidBrush(Color.LawnGreen);

        }

        public void Draw( Graphics g)
        {

            g.FillEllipse(SnakeColor, X*Width, Y*Height, Width , Height);

        }

        public void Stop()
        {

            this.X = X;
            this.Y = Y;

        }

        public void Move()
        {
            
            int maxXPos = 990 / Width;
            int maxYPos = 610 / Height;


            switch (Direction)
            {
                case direction.Right:
                    X++;
                    break;
                case direction.Left:
                    X--;
                    break;
                case direction.Up:
                    Y--;
                    break;
                case direction.Down:
                    Y++;
                    break;
                

            }

            
            //Detect collision with game borders.
            if ( (X < 0) || (Y < 0) || (X >= maxXPos) || (Y >= maxYPos) )
            {
                
                Die();
            }


        }

        public void Update()
        {

            this.Move();

            Console.WriteLine("X = {0} Y = {1}, DIRECT = {2}",X, Y, Direction); 
        }

        public void Die()
        {

            isDead = true;
        
        }

    }
}
