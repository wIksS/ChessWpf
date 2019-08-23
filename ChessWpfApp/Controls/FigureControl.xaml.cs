using ChessWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessWpfApp.Controls
{
    /// <summary>
    /// Interaction logic for FigureControl.xaml
    /// </summary>
    public partial class FigureControl : UserControl
    {
        public static readonly DependencyProperty FigureProperty =
            DependencyProperty.Register
            (
                "Figure", typeof(ChessFigure), typeof(FigureControl),
                new FrameworkPropertyMetadata(null)
            );

        public static readonly DependencyProperty ClickCommandProperty =
    DependencyProperty.Register
    (
        "ClickCommand", typeof(ICommand), typeof(FigureControl),
        new FrameworkPropertyMetadata(null)
    );

        public static readonly DependencyProperty MouseUpCommandProperty =
DependencyProperty.Register
(
"MouseUpCommand", typeof(ICommand), typeof(FigureControl),
new FrameworkPropertyMetadata(null)
);

        public FigureControl(ChessFigure figure):this()
        {
            this.DataContext = new { figure };
        }

        public FigureControl()
        {
            InitializeComponent();
        }

        public ChessFigure Figure
        {
            get { return (ChessFigure)GetValue(FigureProperty); }
            set { SetValue(FigureProperty, value); }
        }

        public ICommand ClickCommand
        {
            get { return (ICommand)GetValue(ClickCommandProperty); }
            set { SetValue(ClickCommandProperty, value); }
        }

        public ICommand MouseUpCommand
        {
            get { return (ICommand)GetValue(MouseUpCommandProperty); }
            set { SetValue(MouseUpCommandProperty, value); }
        }

        private void FigureClicked(object sender, MouseButtonEventArgs e)
        {
            ClickCommand.Execute(Figure);
        }

        private void FigureMouseUp(object sender, MouseButtonEventArgs e)
        {
            MouseUpCommand.Execute(Figure);
        }
    }
}
