using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using PrismMEF.Module1.Controllers;
using System.ComponentModel.Composition;

namespace PrismMEF.Module1
{
    [ModuleExport(typeof(Module1Module))]
    public class Module1Module : IModule
    {
        [ImportingConstructor]
        public Module1Module(IModule1Controller controller)
        {

        }

        public void Initialize()
        {
            //throw new NotImplementedException();
        }
    }
}
