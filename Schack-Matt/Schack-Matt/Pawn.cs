using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Pawn
    {
        public List<Positions> GetAllMoves(Positions currentPos)
        {
            List<Positions> moves = new List<Positions>();
         
            // The code below handles movement for both black and white pieces


            // This part will add all positions along the +y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add all positions along the +2 y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY + 2;
                moves.Add(pos);
            }

            // This part will add all positions along the -y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

            // This part will add all positions along the -2 y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY - 2;
                moves.Add(pos);
            }

            // This part will add all positions along the +x, +y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add all positions along the +x, -y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

            // This part will add all positions along the -x, +y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add all positions along the -x, -y axis

            for (int i = 0; i < 7; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }
        }
    }
}
