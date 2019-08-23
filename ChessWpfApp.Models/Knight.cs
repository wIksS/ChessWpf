using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Models
{
    public class Knight : ChessFigure
    {
        public Knight(string image, int row, int col, bool isWhite)
            :base(image,row,col, isWhite)
        {
            this.Name = "Knight";
        }
    }
}
