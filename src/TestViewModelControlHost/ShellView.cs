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
using System.Reactive.Linq;


namespace TestViewModelControlHost
{
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            cachedControlHost1.Configure((vm) =>
            {
                var view = ViewLocator.Current.ResolveView(vm);
                view.ViewModel = vm;
                return (Control)view;
            });

            this.OneWayBind(ViewModel,
                vm => vm.SelectedScreen,
                v => v.cachedControlHost1.ViewModel);

            this.BindCommand(ViewModel,
                vm => vm.SelectView1,
                v => v.btnSelectView1);

            this.BindCommand(ViewModel,
                vm => vm.SelectView2,
                v => v.btnSelectView2);

            this.BindCommand(ViewModel,
                vm => vm.SelectNullScreen,
                v => v.btnSelectNullView);
        }

        public ShellViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ShellViewModel)value;
        }

    }
}
