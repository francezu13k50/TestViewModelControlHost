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
    public partial class ShellView : Form, IViewFor<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            viewModelControlHost1.CacheViews = true;


            this.OneWayBind(ViewModel,
                vm => vm.SelectedViewModel,
                v => v.viewModelControlHost1.ViewModel);

            this.BindCommand(ViewModel,
                vm => vm.SelectView1,
                v => v.btnSelectView1);

            this.BindCommand(ViewModel,
                vm => vm.SelectView2,
                v => v.btnSelectView2);
        }

        public ShellViewModel ViewModel { get; set; }
        object IViewFor.ViewModel
        {
            get => ViewModel;
            set => ViewModel = (ShellViewModel)value;
        }

    }
}
