using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;
using PrismUnity.Module1.Views.List;
using PrismUnity.Module1.Controllers;

namespace PrismUnity.Module1
{
    public class Module1Module : IModule
    {
        [Dependency]
        public IUnityContainer Container { get; set; } 

        public void Initialize()
        {
            RegisterTypes();

            Container.Resolve<IModule1Controller>();
        }

        private void RegisterTypes()
        {
            Container.RegisterType<IModule1Controller, Module1Controller>(
                new ContainerControlledLifetimeManager());

            Container.RegisterType<IListView, ListView>();
            Container.RegisterType<IListViewModel, ListViewModel>();
        }
    }
}
