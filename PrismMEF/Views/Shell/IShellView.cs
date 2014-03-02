using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMEF.Views.Shell
{
    public interface IShellView
    {
        object DataContext { get; set; }
    }
}
