using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
   public class Board
    {
        Pieces[,] boardOfPieces = new Pieces[8, 8];

        public void PopulateTheBoard()
        {
            #region BlackPieces
            boardOfPieces[0, 0] = new Pieces("Black", 4, "Rook");
            boardOfPieces[1, 0] = new Pieces("Black", 5, "Knight");
            boardOfPieces[2, 0] = new Pieces("Black", 6, "Bishop");
            boardOfPieces[3, 0] = new Pieces("Black", 8, "King");
            boardOfPieces[4, 0] = new Pieces("Black", 7, "Queen");
            boardOfPieces[5, 0] = new Pieces("Black", 6, "Bishop");
            boardOfPieces[6, 0] = new Pieces("Black", 5, "Knight");
            boardOfPieces[7, 0] = new Pieces("Black", 4, "Rook");           

            for (int i = 0; i < 8; i++)
            {
                boardOfPieces[i, 1] = new Pieces("Black", 1, "Pawn");
            }
            #endregion
            #region WhitePieces
            boardOfPieces[0, 8] = new Pieces("White", 4, "Rook");
            boardOfPieces[1, 8] = new Pieces("White", 5, "Knight");
            boardOfPieces[2, 8] = new Pieces("White", 6, "Bishop");
            boardOfPieces[3, 8] = new Pieces("White", 7, "Queen");
            boardOfPieces[4, 8] = new Pieces("White", 8, "King");
            boardOfPieces[5, 8] = new Pieces("White", 6, "Bishop");
            boardOfPieces[6, 8] = new Pieces("White", 5, "Knight");
            boardOfPieces[7, 8] = new Pieces("White", 4, "Rook");

            for (int i = 0; i < 8; i++)
            {
                boardOfPieces[i, 7] = new Pieces("White", 1, "Pawn");
            }          
            #endregion
        }
    }
}
