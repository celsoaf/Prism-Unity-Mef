using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace PrismUnity.Controllers
{
    public class PrismUnityController : IPrismUnityController
    {
        private IUnityContainer _container;

        public PrismUnityController(IUnityContainer container)
        {
            _container = container;
        }
    }
}
