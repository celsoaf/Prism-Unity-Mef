using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using PrismUnity.Infrastructure;
using PrismUnity.Module1.Views.List;
using PrismUnity.Module1.Models;
using System.Collections.ObjectModel;

namespace PrismUnity.Module1.Controllers
{
    public class Module1Controller : IModule1Controller
    {
        private IUnityContainer _container;
        private IEventAggregator _eventAggregator;
        private IRegionManager _regionManager;
        private IListViewModel _list;

        public Module1Controller(
            IUnityContainer container,
            IEventAggregator eventAggregator,
            IRegionManager regionManager)
        {
            _container = container;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;

            _list = _container.Resolve<IListViewModel>();

            _list.Items = new ObservableCollection<ListItem>();

            _list.Items.Add(new ListItem { Id = 1, Name = "Item 1" });
            _list.Items.Add(new ListItem { Id = 2, Name = "Item 2" });
            _list.Items.Add(new ListItem { Id = 3, Name = "Item 3" });

            _regionManager.RegisterViewWithRegion(
                RegionNames.LeftRegion,
                () => _list.View);
        }

    }
}
