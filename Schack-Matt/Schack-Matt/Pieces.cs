using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    public class Pieces
    {
        public int value;
        public string color;
        public string name;
        public Positions currentPosition;
        public List<Positions> PiecesMoves = new List<Positions>();

        public Pieces(string Color, int Value, string Name)
        {
            this.value = Value;
            this.color = Color;
            this.name = Name;
        }
        public void RemoveIllegalMoves(Pieces[,] b)
        {
            //this part removes all moves that would go out of bounds
            for (int i = 0; i < PiecesMoves.Count; i++)
            {
                if (this.PiecesMoves[i].PosX > 7 || this.PiecesMoves[i].PosX < 0 || this.PiecesMoves[i].PosY > 7 || this.PiecesMoves[i].PosY < 0)
                {
                    PiecesMoves.RemoveAt(i);
                    i--;
                }
            }
            // this part removes all moves that would collide with the same color.
            // Implement shanges from row 28 to everything that follows.
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    for (int k = 0; k < b.GetLength(1); k++)
                    {
                        if (this.color == b[j, k].color)
                        {
                            a.Remove(currentPosition);
                            i--;
                        }
                    }
                }
            }
            //this
            for (int i = 0; i < a.Count; i++)
            {
                for (int j = 0; j < b.GetLength(0); j++)
                {
                    for (int k = 0; k < b.GetLength(1); k++)
                    {
                        if (b[j, k] != null)
                        {
                            for (int l = 0; l < b.GetLength(0); l++)
                            {
                                for (int m = 0; m < b.GetLength(1); m++)
                                {
                                    if (b[j, k].currentPosition.PosX < currentPosition.PosX)
                                    {
                                        if (true)
                                        {

                                        }

                                    }
                                    else if (b[j, k].currentPosition.PosX > currentPosition.PosX)
                                    {

                                    }
                                    else
                                    {

                                    }
                                    if (currentPosition.PosY < b[j, k].currentPosition.PosY)
                                    {


                                    }
                                    else if (currentPosition.PosY > b[j, k].currentPosition.PosY)
                                    {

                                    }
                                    else
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
