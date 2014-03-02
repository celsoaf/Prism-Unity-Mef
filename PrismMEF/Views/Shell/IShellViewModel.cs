using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMEF.Views.Shell
{
    public interface IShellViewModel
    {
        IShellView View { get; set; }
    }
}
