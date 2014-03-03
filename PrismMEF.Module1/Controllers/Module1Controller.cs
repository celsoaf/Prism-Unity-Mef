using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using PrismMEF.Module1.Models;
using PrismMEF.Infrastructure;
using System.Collections.ObjectModel;
using PrismMEF.Module1.Views.List;

namespace PrismMEF.Module1.Controllers
{
    [PartCreationPolicy(CreationPolicy.Shared)]
    [Export(typeof(IModule1Controller))]
    public class Module1Controller : IModule1Controller
    {
        //private IUnityContainer _container;
        private IRegionManager _regionManager;
        private IListViewModel _list;

        [ImportingConstructor]
        public Module1Controller(
            //IUnityContainer container,
            IRegionManager regionManager,
            IListViewModel list)
        {
            //_container = container;
            _regionManager = regionManager;

            _list = list;

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
