using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using System.Windows;
using PrismUnity.Views.Shell;
using Microsoft.Practices.Prism.Modularity;
using PrismUnity.Controllers;
using PrismUnity.Views.Bottom;

namespace PrismUnity
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();

            ModuleCatalog catalog = (ModuleCatalog)this.ModuleCatalog;

            //catalog.AddModule(typeof(Backup.BackupModule));
        }

        protected override DependencyObject CreateShell()
        {
            var shell = Container.Resolve<IShellViewModel>();

            var view = shell.View as Window;

            view.Show();

            return view;
        }

        protected override void ConfigureContainer()
        {
            registerTypes();

            base.ConfigureContainer();
        }

        private void registerTypes()
        {
            Container.RegisterType<IPrismUnityController, PrismUnityController>(
                new ContainerControlledLifetimeManager());

            Container.RegisterType<IShellView, ShellView>();
            Container.RegisterType<IShellViewModel, ShellViewModel>();

            Container.RegisterType<IBottomView, BottomView>();
            Container.RegisterType<IBottomViewModel, BottomViewModel>();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();

            Container.Resolve<IPrismUnityController>();
        }
    }
}
