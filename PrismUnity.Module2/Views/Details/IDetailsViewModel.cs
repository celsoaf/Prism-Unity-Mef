using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismUnity.Module2.Views.Details
{
    public interface IDetailsViewModel
    {
        IDetailsView View { get; set; }

        string Description { get; set; }
    }
}
