using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.MefExtensions;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using PrismMEF.Views.Shell;
using System.ComponentModel.Composition.Hosting;
using PrismMEF.Controllers;
using System.ComponentModel.Composition;

namespace PrismMEF
{
    public class Bootstrapper : MefBootstrapper
    {
        protected override void ConfigureAggregateCatalog()
        {
            base.ConfigureAggregateCatalog();

            this.AggregateCatalog.Catalogs.Add(new AssemblyCatalog(typeof(Bootstrapper).Assembly));
        }

        protected override DependencyObject CreateShell()
        {
            var shell = Container.GetExportedValue<IShellViewModel>();

            return shell.View as DependencyObject;
        }

        protected override void InitializeShell()
        {
            //base.InitializeShell();

            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();

            Container.GetExportedValue<IPrismMEFController>();
        }
    }
}
