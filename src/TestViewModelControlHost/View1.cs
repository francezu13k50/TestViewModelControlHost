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

    public partial class View1 : UserControl, IViewFor<ViewModel1>
    {
        private static int _instanceCounter;

        public View1()
        {
            InitializeComponent();

            Debug.WriteLine("New View1");

            IDisposable activationSubscription = Disposable.Empty;
            activationSubscription =
            this.WhenActivated(disposableRegistration =>
            {
                
                Debug.WriteLine("Activating View1");

                label1.Text = $"View1 instance count = {_instanceCounter}";

                Disposable.Create(() => Debug.WriteLine("View1 deactivated"))
                .DisposeWith(disposableRegistration);
                

            });

            _instanceCounter++;

            this.Disposed += (s, e) => activationSubscription.Dispose();
        }




        public ViewModel1 ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ViewModel1)value;
        }
    }
}
