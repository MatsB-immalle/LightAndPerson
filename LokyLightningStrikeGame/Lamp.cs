using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LokyLightningStrikeGame
{
    class Lamp
    {
        private bool brandend = false;

        public void toggle()
        {
            brandend = !brandend;
        }


        public bool Brandend
        {
            get
            {
                return brandend;
            }
        }
    }

    
}
