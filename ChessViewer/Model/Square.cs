namespace ChessViewer.Model
{
    public class Square
    {
        public Square(string id)
        {
            Id = id;
        }

        public static implicit operator Square(string id)
        {
            return new Square(id);
        }

        public string Id
        {
            get
            {
                return RANKS[Column] + Row.ToString();
            }
            set
            {
                if (value.Length == 2 && RANKS.Contains(value[0].ToString()) 
                    && value[1] >= 1 && value[1] <= 8)
                {
                    _id = value;
                    Column = RANKS[value[0]];
                    Row = value[1];
                }
            }
        }

        public int Column { get; set; }
        public int Row { get; set; }

        private string _id;
        private const string RANKS = "abcdefgh";
    }
}