using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestViewModelControlHost
{

    public partial class View2 : UserControl, IViewFor<ViewModel2>
    {
        private static int _instanceCounter;

        public View2()
        {
            InitializeComponent();

            Debug.WriteLine("New View2");

            IDisposable activationSubscription = Disposable.Empty;
            activationSubscription =
            this.WhenActivated(disposableRegistration =>
            {
                
                Debug.WriteLine("Activating View2");

                label1.Text = $"View2 instance count = {_instanceCounter}";

                Disposable.Create(() => Debug.WriteLine("View2 deactivated"))
                .DisposeWith(disposableRegistration);
                

            });

            _instanceCounter++;

            this.Disposed += (s, e) => activationSubscription.Dispose();
        }



        public ViewModel2 ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ViewModel2)value;
        }
    }
}
