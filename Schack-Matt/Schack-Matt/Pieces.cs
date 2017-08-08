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
        public void RemoveIllegalMoves(List<Positions> a, Pieces[,] b)
        {
            //this part removes all moves that would go out of bounds
            for (int i = 0; i < a.Count; i++)
            {
                if (currentPosition.PosX > 7 || currentPosition.PosX < 0 || currentPosition.PosY > 7 || currentPosition.PosY < 0)
                {
                    a.Remove(currentPosition);
                    i--;
                }
            }
            // this part removes all moves that would collide with the same color.
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
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    if (b[i, j] != null)
                    {
                        for (int k = 0; k < b.GetLength(0); k++)
                        {
                            for (int l = 0; l < b.GetLength(1); l++)
                            {
                                if (currentPosition.PosX < b[i,j].currentPosition.PosX)
                                {

                                }
                                else if (currentPosition.PosX > b[i, j].currentPosition.PosX)
                                {

                                }
                                else
                                {

                                }
                                if (currentPosition.PosY < b[i, j].currentPosition.PosY)
                                {

                                }
                                else if (currentPosition.PosY > b[i, j].currentPosition.PosY)
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
