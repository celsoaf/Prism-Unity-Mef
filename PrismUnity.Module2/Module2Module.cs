using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using PrismUnity.Module2.Views.Details;
using Microsoft.Practices.Prism.Regions;
using PrismUnity.Infrastructure;

namespace PrismUnity.Module2
{
    public class Module2Module : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; }

        public void Initialize()
        {
            RegisterTypes();

            Container.Resolve<IRegionManager>().RegisterViewWithRegion(
                RegionNames.RightRegion,
                () => Container.Resolve<IDetailsViewModel>().View);
        }

        private void RegisterTypes()
        {
            Container.RegisterType<IDetailsView, DetailsView>();
            Container.RegisterType<IDetailsViewModel, DetailsViewModel>();
        }
    }
}
