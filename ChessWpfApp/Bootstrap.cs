using Autofac;
using ChessWpfApp.Services;
using ChessWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessWpfApp
{
    public class Bootstrap
    {
        public static IContainer Init()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindowViewModel>();
            builder.RegisterType<ChessGridViewModel>();
            builder.RegisterType<ChessRulesService>();
            builder.RegisterType<BoardGeneratorService>();

            return builder.Build();
        }

        public static IContainer Container { get; set; }
    }
}
