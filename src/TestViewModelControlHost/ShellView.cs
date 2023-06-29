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

            viewModelControlHost1.CacheViews = true;


            //this.OneWayBind(ViewModel,
            //    vm => vm.SelectedViewModel,
            //    v => v.viewModelControlHost1.ViewModel);


            this.WhenAnyValue(v => v.ViewModel.SelectedViewModel)
                .WhereNotNull()
                .Select(vm =>
                {
                    var view = ViewLocator.Current.ResolveView(vm);
                    view.ViewModel = vm;
                    return view;
                })
                .Cast<Control>()
                .Subscribe(view =>
                {

                    panel1.SuspendLayout();
                    // clear out existing visible control view
                    foreach (Control c in panel1.Controls)
                    {
                        //var v = (IViewFor)c;
                        //v.ViewModel = null;
                        c.Hide();
                        panel1.Controls.Remove(c);
                    }

                    view.Dock = DockStyle.Fill;
                    panel1.Controls.Add(view);
                    view.Show();

                    panel1.ResumeLayout();
                });

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
