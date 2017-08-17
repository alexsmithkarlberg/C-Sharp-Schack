using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    public class Board
    {
        Pieces[] boardOfPieces = new Pieces[32];
        int counter = 0;

        public void PopulateTheBoard()
        {
            #region BlackPieces
            boardOfPieces[0] = new Pieces("Black", 4, "Rook", 0, 0);
            boardOfPieces[1] = new Pieces("Black", 5, "Knight", 0, 1);
            boardOfPieces[2] = new Pieces("Black", 6, "Bishop", 0, 2);
            boardOfPieces[3] = new Pieces("Black", 8, "King", 0, 3);
            boardOfPieces[4] = new Pieces("Black", 7, "Queen", 0, 4);
            boardOfPieces[5] = new Pieces("Black", 6, "Bishop", 0, 5);
            boardOfPieces[6] = new Pieces("Black", 5, "Knight", 0, 6);
            boardOfPieces[7] = new Pieces("Black", 4, "Rook", 0, 7);

            for (int i = 8; i < 16; i++)
            {                
                boardOfPieces[i] = new Pieces("Black", 1, "Pawn", 1, counter);
                counter++;
            }
            counter = 0;
            #endregion
            #region WhitePieces
            boardOfPieces[16] = new Pieces("White", 4, "Rook", 7, 0);
            boardOfPieces[17] = new Pieces("White", 5, "Knight", 7, 1);
            boardOfPieces[18] = new Pieces("White", 6, "Bishop", 7, 2);
            boardOfPieces[19] = new Pieces("White", 7, "Queen", 7, 3);
            boardOfPieces[20] = new Pieces("White", 8, "King", 7, 4);
            boardOfPieces[21] = new Pieces("White", 6, "Bishop", 7, 5);
            boardOfPieces[22] = new Pieces("White", 5, "Knight", 7, 6);
            boardOfPieces[23] = new Pieces("White", 4, "Rook", 7, 7);

            for (int i = 24; i < 32; i++)
            {
                boardOfPieces[i] = new Pieces("White", 1, "Pawn", 6, counter);
                counter++;
            }
            counter = 0;
            #endregion
        }
    }
}
