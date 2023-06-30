using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestViewModelControlHost
{
    public class ShellViewModel : ReactiveObject
    {

        private readonly object _viewModel1 = new ViewModel1();
        private readonly object _viewModel2 = new ViewModel2();
        private readonly object _nullScreen = null;

        public ShellViewModel()
        {
            _selectedScreen =
            Observable.Merge(SelectView1.Select(_ => _viewModel1),
                             SelectView2.Select(_ => _viewModel2),
                             SelectNullScreen.Select(_ => _nullScreen))
                .Do(x => Debug.WriteLine($"Setting SelectedScreen to {x}"))
                .ToProperty(this, vm => vm.SelectedScreen);

        }

        public ReactiveCommand<Unit, Unit> SelectView1 { get; } = ReactiveCommand.Create(() => { });
        public ReactiveCommand<Unit, Unit> SelectView2 { get; } = ReactiveCommand.Create(() => { });

        public ReactiveCommand<Unit, Unit> SelectNullScreen { get; } = ReactiveCommand.Create(() => { });

        private ObservableAsPropertyHelper<object> _selectedScreen;

        public object SelectedScreen { get => _selectedScreen.Value; }
    }
}
