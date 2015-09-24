using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
  public  class Cell
    {

        public int Xpos { get; set; }
        public int Ypos { get; set; }

        public Cell(int x, int y)
        {

            this.Xpos = x;
            this.Ypos = y;

        }

    }
}
