using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using PrismMEF.Infrastructure;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using PrismMEF.Infrastructure.Events;
using System.ComponentModel.Composition.Hosting;
using PrismMEF.Views.StatusBar;

namespace PrismMEF.Controllers
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [Export(typeof(IPrismMEFController))]
    public class PrismMEFController : IPrismMEFController
    {
        //private CompositionContainer _container;
        private IEventAggregator _eventAggregator;
        private IRegionManager _regionManager;

        [ImportingConstructor]
        public PrismMEFController(
            IEventAggregator eventAggregator,
            IRegionManager regionManager,
            IStatusBarViewModel statusBar)
        {
            //_container = container;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;

            _regionManager.RegisterViewWithRegion(
                RegionNames.BottomRegion,
                () => statusBar.View);

            _eventAggregator.GetEvent<ExitApplicationEvent>().Subscribe(obj =>
                {
                    App.Current.MainWindow.Close();
                });
        }
    }
}
