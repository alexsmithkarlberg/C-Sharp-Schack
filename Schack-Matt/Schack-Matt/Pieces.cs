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
        public void RemoveIllegalMovesOutOfBounds()
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



        }
        public void RemoveIllegalMovesColorCollide(Pieces[,] b)
        {
            // This part removes all moves that would collide with a piece of the same color.
            for (int i = 0; i < PiecesMoves.Count; i++)
            {
                if (this.color == b[PiecesMoves[i].PosX, PiecesMoves[i].PosY].color)
                {
                    this.PiecesMoves.RemoveAt(i);
                    i--;
                }
            }
        }
        public void RemoveIllegalMovesBehindTarget(Pieces[,] b)
        {
            //this part removes all illegal moves behind a target
            for (int i = 0; i < PiecesMoves.Count; i++)
            {
                if (b[PiecesMoves[i].PosX, PiecesMoves[i].PosY] != null)
                {

                    int x = PiecesMoves[i].PosX - currentPosition.PosX;
                    int y = PiecesMoves[i].PosY - currentPosition.PosY;
                    if (x > 0 && y > 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) > 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) > 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x < 0 && y < 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) < 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) < 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x > 0 && y < 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) > 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) < 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x < 0 && y > 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) < 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) > 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x > 0 && y == 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) > 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) == 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x == 0 && y > 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) == 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) > 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x < 0 && y == 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) < 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) == 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                    else if (x == 0 && y < 0)
                    {
                        for (int j = 0; j < PiecesMoves.Count; j++)
                        {
                            if ((PiecesMoves[j].PosX - PiecesMoves[i].PosX) == 0 && (PiecesMoves[j].PosY - PiecesMoves[i].PosY) < 0)
                            {
                                PiecesMoves.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }
            }
        }
    }
}

