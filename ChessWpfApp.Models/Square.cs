using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Models
{
    public class Square
    {
        public Square(int row, int col,string color, ChessFigure figure)
        {
            this.Color = color;
            this.Row = row;
            this.Col = col;
            this.Figure = figure;
        }
        public int Id { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public string Color { get; set; }

        public ChessFigure Figure { get; set; }
    }
}
