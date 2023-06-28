using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace TestViewModelControlHost
{
    public class ViewModel1 : ReactiveObject, IActivatableViewModel
    {

        public ViewModel1()
        {
            Activator = new ViewModelActivator();
            this.WhenActivated(disposableRegistration =>
            {
                Debug.WriteLine("Activating ViewModel1");



                Disposable.Create(() => Debug.WriteLine("ViewModel1 deactivated"))
                .DisposeWith(disposableRegistration);

            });
        }

        public ViewModelActivator Activator { get; }
    }
}
