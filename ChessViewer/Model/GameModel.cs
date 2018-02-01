using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessViewer.Model
{
    public class GameModel
    {
        public List<Piece> Pieces { get; set; }
        public List<Move> Moves { get; set; }
        public Side ToMove { get; set; }

        public GamePage Observer { get; set; }

        public GameModel()
        {
            Pieces = new List<Piece>()
            {
                new Pawn(Side.White, "a2"),
                new Pawn(Side.White, "b2"),
                new Pawn(Side.White, "c2"),
                new Pawn(Side.White, "d2"),
                new Pawn(Side.White, "e2"),
                new Pawn(Side.White, "f2"),
                new Pawn(Side.White, "g2"),
                new Pawn(Side.White, "h2"),
                new Rook(Side.White, "a1"),
                new Knight(Side.White, "b1"),
                new Bishop(Side.White, "c1"),
                new Queen(Side.White, "d1"),
                new King(Side.White, "e1"),
                new Bishop(Side.White, "f1"),
                new Knight(Side.White, "g1"),
                new Rook(Side.White, "h1"),

                new Pawn(Side.Black, "a7"),
                new Pawn(Side.Black, "b7"),
                new Pawn(Side.Black, "c7"),
                new Pawn(Side.Black, "d7"),
                new Pawn(Side.Black, "e7"),
                new Pawn(Side.Black, "f7"),
                new Pawn(Side.Black, "g7"),
                new Pawn(Side.Black, "h7"),
                new Rook(Side.Black, "a8"),
                new Knight(Side.Black, "b8"),
                new Bishop(Side.Black, "c8"),
                new Queen(Side.Black, "d8"),
                new King(Side.Black, "e8"),
                new Bishop(Side.Black, "f8"),
                new Knight(Side.Black, "g8"),
                new Rook(Side.Black, "h8")
            };

            Moves = new List<Move>();
            ToMove = Side.White;
        }

    }
}
