using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Models
{
    public class Empty : ChessFigure
    {
        public Empty(int row, int col)
            : base("", row, col, false)
        {
            this.Name = "Empty";
        }
    }
}
