using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Models
{
    public class ChessFigure
    {
        public ChessFigure(string image, int row, int col, bool isWhite)
        {
            this.IsWhite = isWhite;
            this.Row = row;
            this.Col = col;
            this.Image = image;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public string Image { get; set; }

        public bool IsWhite{ get; set; }
    }
}
