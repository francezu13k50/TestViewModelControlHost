using ReactiveUI;
using Splat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestViewModelControlHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            Locator.CurrentMutable.RegisterConstant(new ShellView(), typeof(IViewFor<ShellViewModel>));
            Locator.CurrentMutable.RegisterLazySingleton<IViewFor<ViewModel1>>(() => new View1());
            Locator.CurrentMutable.RegisterLazySingleton<IViewFor<ViewModel2>>(() => new View2());


            //var vm = new ShellViewModel();
            //var shellView = Locator.Current.GetService<IViewFor<ShellViewModel>>();
            //shellView.ViewModel = vm;

            var shellView = GetAndConfigureViewFor(new ShellViewModel());
            Application.Run(shellView as Form);
        }

        private static IViewFor<T> GetAndConfigureViewFor<T>(T viewModel) where T:  ReactiveObject
        {
            var view = Locator.Current.GetService<IViewFor<T>>();
            view.ViewModel = viewModel;

            return view;
        }
    }
}
