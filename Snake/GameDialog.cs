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
    public partial class GameDialog : Form
    {



        public GameDialog()
        {
            InitializeComponent();
            
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {


            // MainWindow.NewGame();

        }
    }
}
