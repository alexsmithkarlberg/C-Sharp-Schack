using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Bishop
    {
        public List<Positions> GetAllMoves(Positions currentPos)
        {
            List<Positions> moves = new List<Positions>();
            // This part will add all positions along the +x, +y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add all positions along the +x, -y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

            // This part will add all positions along the -x, +y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add all positions along the -x, -y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

        }
    }
}
