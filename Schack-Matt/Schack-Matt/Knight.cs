using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Knight : Pieces
    {
        public Knight(string Color, int Value, string Name) : base(Color, Value, Name)
        {
        }

        public List<Positions> GetAllMoves(Positions currentPos)
        {
            List<Positions> moves = new List<Positions>();
            // This part will add positions along the +x, +y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 2;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add positions along the +x, -y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 2;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

            // This part will add positions along the -x, +y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 2;
                pos.PosY = currentPos.PosY + 1;
                moves.Add(pos);
            }

            // This part will add positions along the -x, -y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 2;
                pos.PosY = currentPos.PosY - 1;
                moves.Add(pos);
            }

            // This part will add positions along the +x, +y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY + 2;
                moves.Add(pos);
            }

            // This part will add positions along the +x, -y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY - 2;
                moves.Add(pos);
            }

            // This part will add positions along the -x, +y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY + 2;
                moves.Add(pos);
            }

            // This part will add positions along the -x, -y axis

            for (int i = 0; i < 1; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY - 2;
                moves.Add(pos);
            }

        }
    }
}
