using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessViewer.Model
{
    public class Move
    {
        public Piece Piece { get; set; }
        public Square From { get; set; }
        public Square To { get; set; }
        public string Comment { get; set; }
    }
}
