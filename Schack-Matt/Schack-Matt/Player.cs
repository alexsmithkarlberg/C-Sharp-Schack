using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schack_Matt
{
    class Player
    {
        bool playerColorChoice;

        private void PlayerBlackPieces()
        {
            List<Pieces> blackPieces = new List<Pieces>();

            Pieces bKing = new Pieces();
            bKing.color = "Black";
            bKing.name = "King";
            bKing.value = 8;
            blackPieces.Add(bKing);

            Pieces bQueen = new Pieces();
            bQueen.color = "Black";
            bQueen.name = "Queen";
            bQueen.value = 7;
            blackPieces.Add(bQueen);

            for (int i = 0; i < 2; i++)
            {
                Pieces bBishop = new Pieces();
                bBishop.color = "Black";
                bBishop.name = "Bishop";
                bBishop.value = 6;
                blackPieces.Add(bBishop);
            }

            for (int i = 0; i < 2; i++)
            {
                Pieces bKnight = new Pieces();
                bKnight.color = "Black";
                bKnight.name = "Knight";
                bKnight.value = 5;
                blackPieces.Add(bKnight);
            }

            for (int i = 0; i < 2; i++)
            {
                Pieces bRook = new Pieces();
                bRook.color = "Black";
                bRook.name = "Rook";
                bRook.value = 4;
                blackPieces.Add(bRook);
            }
            
            for (int i = 0; i < 8; i++)
            {
                Pieces bPawn = new Pieces();
                bPawn.color = "Black";
                bPawn.name = "Pawn";
                bPawn.value = 1;
                blackPieces.Add(bPawn);
            }
        }
        private void PlayerWhitePieces()
        {
            List<Pieces> whitePieces = new List<Pieces>();

            Pieces wKing = new Pieces();
            wKing.color = "White";
            wKing.name = "King";
            wKing.value = 8;
            whitePieces.Add(wKing);

            Pieces wQueen = new Pieces();
            wQueen.color = "White";
            wQueen.name = "Queen";
            wQueen.value = 7;
            whitePieces.Add(wQueen);

            for (int i = 0; i < 2; i++)
            {
                Pieces wBishop = new Pieces();
                wBishop.color = "White";
                wBishop.name = "Bishop";
                wBishop.value = 6;
                whitePieces.Add(wBishop);
            }

            for (int i = 0; i < 2; i++)
            {
                Pieces wKnight = new Pieces();
                wKnight.color = "White";
                wKnight.name = "Knight";
                wKnight.value = 5;
                whitePieces.Add(wKnight);
            }

            for (int i = 0; i < 2; i++)
            {
                Pieces wRook = new Pieces();
                wRook.color = "White";
                wRook.name = "Rook";
                wRook.value = 4;
                whitePieces.Add(wRook);
            }

            for (int i = 0; i < 8; i++)
            {
                Pieces wPawn = new Pieces();
                wPawn.color = "White";
                wPawn.name = "Pawn";
                wPawn.value = 1;
                whitePieces.Add(wPawn);
            }
        }
    }

}
