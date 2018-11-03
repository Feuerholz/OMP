using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMP.Model
{
    public class Set
    {
        public int BlueScore;
        public int RedScore;
        public Team Winner;

        public Set()
        {
            BlueScore = 0;
            RedScore = 0;
        }

        public void BlueWin()
        {
            BlueScore++;
        }

        public void RedWin()
        {
            RedScore++;
        }
    }
}
