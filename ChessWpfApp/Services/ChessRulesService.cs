using ChessWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Services
{
    public class ChessRulesService
    {
        public bool CanMove(Pawn from, ChessFigure to)
        {
            if (from.Col == to.Col)
            {
                if (from.IsWhite)
                {
                    if (from.Row - to.Row == 1)
                    {
                        return true;
                    }
           
                }
                else
                {
                    if (to.Row - from.Row == 1)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CanMove(Knight from, ChessFigure to)
        {
            var absCol = to.Col - from.Col;
            var absRow = to.Row - from.Row;
            if (absCol== 1 || absCol==-1)
            {
                if (absRow == 2 || absRow==-2)
                {
                    return true;
                }
            }
            if (absCol == 2 || absCol == -2)
            {
                if (absRow == 1 || absRow == -1)
                {
                    return true;
                }
            }

            return false;
        }

        public bool CanMove(ChessFigure from, ChessFigure to)
        {
     
            return false;
        }


    }
}
