using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using PrismMEF.Module2.Views.Details;
using PrismMEF.Infrastructure;

namespace PrismMEF.Module2
{
    [ModuleExport(typeof(Module2Module))]
    public class Module2Module : IModule
    {
        [ImportingConstructor]
        public Module2Module(IRegionManager regionManager, IDetailsViewModel details)
        {
            regionManager.RegisterViewWithRegion(
                RegionNames.RightRegion,
                () => details.View);
        }

        public void Initialize()
        {
            //throw new NotImplementedException();
        }
    }
}
