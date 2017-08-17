using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Queen : Pieces
    {
        public Queen(string Color, int Value, string Name, int PosX, int PosY) : base(Color, Value, Name, PosX, PosY)
        {
        }

        public void GetAllMoves(Positions currentPos)
        {     
            // This part will add all positions along the +y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY + 1;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the -y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX;
                pos.PosY = currentPos.PosY - 1;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the +x axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the -x axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the +x, +y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY + 1;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the +x, -y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX + 1;
                pos.PosY = currentPos.PosY - 1 ;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the -x, +y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY + 1;
                this.PiecesMoves.Add(pos);
            }

            // This part will add all positions along the -x, -y axis

            for (int i = 0; i < 8; i++)
            {
                Positions pos = new Positions();
                pos.PosX = currentPos.PosX - 1;
                pos.PosY = currentPos.PosY - 1;
                this.PiecesMoves.Add(pos);
            }
        }

    }
}
