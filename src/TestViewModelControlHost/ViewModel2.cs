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
    public class ViewModel2 : ReactiveObject, IActivatableViewModel
    {

        public ViewModel2()
        {
            Activator = new ViewModelActivator();
            this.WhenActivated(disposableRegistration =>
            {
                Debug.WriteLine("Activating ViewModel2");



                Disposable.Create(() => Debug.WriteLine("ViewModel2 deactivated"))
                .DisposeWith(disposableRegistration);

            });
        }

        public ViewModelActivator Activator { get; }
    }
}
