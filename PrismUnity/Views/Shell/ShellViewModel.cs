using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Views.Shell
{
    public class ShellViewModel : IShellViewModel
    {
        public ShellViewModel(IShellView view)
        {
            View = view;
            View.DataContext = this;
        }

        public IShellView View { get; set; }
    }
}
