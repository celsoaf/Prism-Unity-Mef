using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Views.Bottom
{
    public class BottomViewModel : IBottomViewModel
    {
        public BottomViewModel(IBottomView view)
        {
            View = view;
            View.DataContext = this;
        }

        public IBottomView View { get; set; }
    }
}
