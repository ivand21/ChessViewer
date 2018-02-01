using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessViewer.Model
{
    public abstract class Piece
    {
        public Side Color { get; set; }
        public Square Square { get; set; }

        public Piece(Side color, Square square)
        {
            Color = color;
            Square = square;
        }
    }
}
