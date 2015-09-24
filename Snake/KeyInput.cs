using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public class KeyInput
    {

        private static Hashtable KeyTable = new Hashtable();

        public static bool KeyPressed(Keys key)
        {

            if (KeyTable[key] == null)
            {
                return false;
            }

            return (bool) KeyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {

            KeyTable[key] = state;

        }

    }
}
