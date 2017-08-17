using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Chess
    {
        List<Positions> AllMoves = new List<Positions>();

        private List<Positions> CopyList(List<Positions> a, List<Positions> b)
        {
            a = b;
            return b;
        }
        private List<Positions> ClearList(List<Positions> a)
        {
            a.Clear();
            return a;
        }
    }
}
