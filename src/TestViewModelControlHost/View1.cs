using ReactiveUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

            this.WhenActivated(disposableRegistration =>
            {
                label1.Text = $"View1 instance {_instanceCounter}";

            });

            _instanceCounter++;
        }



        public ViewModel1 ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ViewModel1)value;
        }
    }
}
