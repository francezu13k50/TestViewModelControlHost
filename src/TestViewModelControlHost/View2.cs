using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int _instanceCounter;

        public View2()
        {
            InitializeComponent();

            IDisposable activationSubscription = Disposable.Empty;
            activationSubscription =
            this.WhenActivated(disposableRegistration =>
            {
                label1.Text = $"View2 instance {_instanceCounter}";

                activationSubscription
                .DisposeWith(disposableRegistration);
            });

            _instanceCounter++;
        }



        public ViewModel2 ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ViewModel2)value;
        }
    }
}
