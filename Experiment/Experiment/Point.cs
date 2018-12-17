using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment
{
    struct Point
    {
        int direction;
        public int Direction
        {
            get { return direction; }
            set
            {
                if (value == 0)
                    direction = -1;
                else
                    direction = 1;
            }
        }
    }
}
