using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Views.StatusBar
{
    public class StatusBarViewModel : IStatusBarViewModel
    {
        public StatusBarViewModel(IStatusBarView view)
        {
            View = view;
            View.DataContext = this;
        }

        public IStatusBarView View { get; set; }
    }
}
