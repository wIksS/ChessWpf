using ChessWpfApp.Models;
using ChessWpfApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChessWpfApp.ViewModels
{
    public class ChessGridViewModel
    {
        private ICommand initGrid;
        private ICommand clickFigure;
        private ICommand mouseUpFigure;
        private ChessFigure selected;
        private ChessRulesService rules;
        private BoardGeneratorService generator;

        public ChessGridViewModel(ChessRulesService chessRules, BoardGeneratorService generator)
        {
            this.generator = generator;
            this.rules = chessRules;
            this.Squares = new ObservableCollection<Square>();
        }

        public ObservableCollection<Square> Squares { get; set; }

        public ICommand InitGrid
        {
            get
            {
                return initGrid ?? (initGrid = new RelayCommand<object>(
                   x =>
                   {
                       Init();
                   }));
            }

        }

        public ICommand ClickFigure
        {
            get
            {
                return clickFigure ?? (clickFigure = new RelayCommand<ChessFigure>(
                   x =>
                   {
                       FigureClicked(x);
                   }));
            }
        }

        public ICommand MouseUpFigure
        {
            get
            {
                return mouseUpFigure ?? (mouseUpFigure = new RelayCommand<ChessFigure>(
                   x =>
                   {
                       FigureMouseUp(x);
                   }));
            }
        }


        public void FigureClicked(ChessFigure figure)
        {
            selected = figure;
            //Task.Run(() =>
            //{
            //    MessageBox.Show(figure.Name + " " + figure.Row.ToString() + " " + figure.Col.ToString());

            //});
        }

        public void FigureMouseUp(ChessFigure figure)
        {
            dynamic s = selected;
            if (!rules.CanMove(s, figure))
            {
                return;
            }
            var square = this.Squares.First(
                x => x.Row == figure.Row && x.Col == figure.Col);
            var selectedSquare = this.Squares.First(
            x => x.Row == selected.Row && x.Col == selected.Col);
            var index = this.Squares.IndexOf(square);
            var selectedIndex = this.Squares.IndexOf(selectedSquare);
            selected.Row = square.Row;
            selected.Col = square.Col;
            Squares[index] = new Square(square.Row, square.Col, square.Color, selected);

            Squares[selectedIndex] = new Square(selectedSquare.Row, selectedSquare.Col, selectedSquare.Color,
                new Empty(selectedSquare.Row, selectedSquare.Col));

            //Task.Run(() =>
            //{
            //    MessageBox.Show(figure.Name + " " + figure.Row.ToString() + " " + figure.Col.ToString());

            //});
        }

        private void Init()
        {
            var board = generator.Generate();
            foreach (var item in board)
            {
                Squares.Add(item);
            }
        }
    }
}
