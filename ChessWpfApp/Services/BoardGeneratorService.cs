using ChessWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp.Services
{
    public class BoardGeneratorService
    {
        public Square[,] Generate()
        {
            var board = new Square[8, 8];
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    var image = "";
                    Square square;
                    ChessFigure figure = new Empty(row, col);
                    if (row == 0 && (col == 1 || col == 6))
                    {
                        figure = new Knight("/Images/blackknight.png", row, col, false);
                    }

                    if (row == 7 && (col == 1 || col == 6))
                    {
                        figure = new Knight("/Images/whiteknight.png", row, col, true);
                    }

                    if (row == 0 && (col == 4))
                    {
                        figure = new Queen("/Images/blackqueen.png", row, col, true);
                    }

                    if (row == 1)
                    {
                        figure = new Pawn("/Images/blackpawn.png", row, col, false);
                    }
                    if (row == 6)
                    {
                        figure = new Pawn("/Images/whitepawn.png", row, col, true);
                    }
                    if ((col + row) % 2 == 0)
                    {
                        square = new Square(row, col, "Orange", figure);
                    }
                    else
                    {
                        square = new Square(row, col, "white", figure);

                    }

                    board[row, col] = square;
                }
            }

            return board;
        }
    }
}
