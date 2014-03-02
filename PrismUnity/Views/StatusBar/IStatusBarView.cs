using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Views.StatusBar
{
    public interface IStatusBarView
    {
        object DataContext { get; set; }
    }
}
