using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;


namespace TestViewModelControlHost
{
    public partial class CachedControlHost : UserControl
    {
        private BehaviorSubject<object> _viewModelSubject = new BehaviorSubject<object>(null);
        private Dictionary<object, Control> _viewCache = new Dictionary<object, Control>();
        private Func<object, Control> _vmToViewResolver;

        public CachedControlHost()
        {
            InitializeComponent();

            var subscription =
                _viewModelSubject
                .Select(vm =>
                {
                    if (vm == null) 
                        return null;

                    if (_vmToViewResolver == null) 
                        throw new InvalidOperationException("No viewModelToViewResolver found. CachedControlHost should be configured before use.");

                    if (!_viewCache.TryGetValue(vm, out var view))
                        view = _viewCache[vm] = _vmToViewResolver(vm);
                   
                    return view;
                })
                .Subscribe(view =>
                {

                    this.SuspendLayout();
                    // clear out existing visible control views
                    foreach (Control c in Controls)
                    {
                        c.Hide();
                        Controls.Remove(c);
                    }

                    if (view != null)
                    {
                        view.Dock = DockStyle.Fill;
                        Controls.Add(view);
                        view.Show();
                    }
                    ResumeLayout();
                });



            this.Disposed += (s, e) =>
            { 
                subscription.Dispose();
                foreach (Control view in _viewCache.Values)
                {
                        view.Dispose();
                }
            };
        }


        public void Configure(Func<object,Control> viewModelToViewResolver)
        {
            _vmToViewResolver = viewModelToViewResolver;
        }


        public object ViewModel
        {
            get => _viewModelSubject.Value;
            set => _viewModelSubject.OnNext(value);
        }

    }
}
