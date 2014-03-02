using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Module2.Views.Details
{
    public interface IDetailsView
    {
        object DataContext { get; set; }
    }
}
