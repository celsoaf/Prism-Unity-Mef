using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Events;
using PrismUnity.Infrastructure.Events;

namespace PrismUnity.Controllers
{
    public class PrismUnityController : IPrismUnityController
    {
        private IUnityContainer _container;
        private IEventAggregator _eventAggregator;

        public PrismUnityController(IUnityContainer container, IEventAggregator eventAggregator)
        {
            _container = container;
            _eventAggregator = eventAggregator;

            _eventAggregator.GetEvent<ExitApplicationEvent>().Subscribe(obj =>
                {
                    App.Current.MainWindow.Close();
                });
        }
    }
}
