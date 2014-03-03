using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.MefExtensions.Modularity;

namespace PrismMEF.Module2
{
    [ModuleExport(typeof(Module2Module))]
    public class Module2Module : IModule
    {
        public void Initialize()
        {
            //throw new NotImplementedException();
        }
    }
}
