using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace PrismMEF.Views.Shell
{
    public interface IShellViewModel
    {
        IShellView View { get; set; }

        ICommand ExitCommand { get; set; }
    }
}
