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

            Locator.CurrentMutable.RegisterViewsForViewModels(Assembly.GetExecutingAssembly());

            var vm = new ShellViewModel();
            var shellView = Locator.Current.GetService<IViewFor<ShellViewModel>>();
            shellView.ViewModel = vm;

            Application.Run(shellView as Form);
        }
    }
}
