using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Snake
{
    public class Controller
    {


        public static Timer GameTimer;
        public Snake Snake;
        public MainWindow Gui;

        public Controller()
        {
            GameTimer = new Timer();
            Snake = new Snake();
        }



        public void StartGui()
        {

            Gui = new MainWindow();
            Application.Run(Gui);
        }



        public void Update(object sender, EventArgs e)
        {
            Snake.Update();
            
        }
     

    }
}
