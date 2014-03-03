using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMEF.Views.StatusBar
{
    public interface IStatusBarViewModel
    {
        IStatusBarView View { get; set; }

        string Status { get; set; }
    }
}
