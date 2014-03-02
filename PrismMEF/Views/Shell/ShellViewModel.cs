using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace PrismMEF.Views.Shell
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : IShellViewModel
    {
        [ImportingConstructor]
        public ShellViewModel(IShellView view)
        {
            View = view;
            View.DataContext = this;
        }

        public IShellView View { get; set; }
    }
}
