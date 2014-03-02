using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using PrismUnity.Infrastructure.Events;
using Microsoft.Practices.Prism.Regions;
using PrismUnity.Infrastructure;
using PrismUnity.Views.Bottom;

namespace PrismUnity.Controllers
{
    public class PrismUnityController : IPrismUnityController
    {
        private IUnityContainer _container;
        private IEventAggregator _eventAggregator;
        private IRegionManager _regionManager;

        public PrismUnityController(
            IUnityContainer container, 
            IEventAggregator eventAggregator,
            IRegionManager regionManager)
        {
            _container = container;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;

            _regionManager.RegisterViewWithRegion(
                RegionNames.BottomRegion,
                () => _container.Resolve<IBottomViewModel>().View);

            _eventAggregator.GetEvent<ExitApplicationEvent>().Subscribe(obj =>
                {
                    App.Current.MainWindow.Close();
                });
        }
    }
}
