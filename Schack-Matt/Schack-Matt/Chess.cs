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
        private List<Positions> AllAvailableMoves(List<Positions> a, Pieces[,] b)
        {
            for (int x = 0; x < b.GetLength(0); x++)
            {
                for (int y = 0; y < b.GetLength(1); y++)
                {
                    if (b[x, y] != null)
                    {
                        if ()
                        {

                        }
                    }
                }
            }
        }
        private List<int> OutOfBounds()
        {

        }
    }
}
