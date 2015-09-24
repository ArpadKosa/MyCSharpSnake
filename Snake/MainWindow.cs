using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainWindow : Form
    {
        static GameDialog dialog = new GameDialog();
        static Controller controller;
        static Timer timer = new Timer();
       
        public static bool IsGameover { get; set; }

        public Snake s = new Snake();

        public MainWindow()
        {
            InitializeComponent();

            

            controller = new Controller();

            StartGame();

        }


        public static void NewGame()
        {
            dialog.Visible = false;
            IsGameover = false;
            controller.Snake.ResetDefaults();
            timer.Start();

        }


        public void Restart()
        {

            //   dialog.Visible = true;
            MainWindow.NewGame();


        }


        public void StartGame()
        {
            IsGameover = false;


            timer.Interval = 90;
            timer.Tick += updateScreen;
            timer.Start();

        }

        public void updateScreen(object sender, EventArgs e)
        {

            if (Snake.isDead == false && IsGameover == false)
            {

                controller.Snake.Update();

                if (KeyInput.KeyPressed(Keys.Right) && controller.Snake.Direction != Snake.direction.Left)
                    controller.Snake.Direction = Snake.direction.Right;
                else if (KeyInput.KeyPressed(Keys.Left) && controller.Snake.Direction != Snake.direction.Right)
                    controller.Snake.Direction = Snake.direction.Left;
                else if (KeyInput.KeyPressed(Keys.Up) && controller.Snake.Direction != Snake.direction.Down)
                    controller.Snake.Direction = Snake.direction.Up;
                else if (KeyInput.KeyPressed(Keys.Down) && controller.Snake.Direction != Snake.direction.Up)
                    controller.Snake.Direction = Snake.direction.Down;

                this.Canvas.Invalidate();
            }
            else
            {
                timer.Stop();
                IsGameover = true;
                Restart();

            }
           
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {

            controller.Snake.Draw(e.Graphics);
           
        }

        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, false);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, true);
        }
    }
}
