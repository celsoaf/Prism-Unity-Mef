using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismMEF.Module1.Views.List
{
    public interface IListView
    {
        object DataContext { get; set; }
    }
}
