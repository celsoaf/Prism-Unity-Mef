using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Events;
using PrismMEF.Infrastructure.Events;
using Microsoft.Practices.Prism.ViewModel;

namespace PrismMEF.Views.StatusBar
{
    [Export(typeof(IStatusBarViewModel))]
    public class StatusBarViewModel : NotificationObject, IStatusBarViewModel
    {
        [ImportingConstructor]
        public StatusBarViewModel(IStatusBarView view, IEventAggregator eventAggregator)
        {
            View = view;
            View.DataContext = this;

            eventAggregator.GetEvent<ItemSelectedEvent>().Subscribe(s => Status = s);
        }

        public IStatusBarView View { get; set; }

        private string _Status;
        public string Status
        {
            get
            {
                return _Status;
            }
            set
            {
                _Status = value;

                RaisePropertyChanged(() => Status);
            }
        }
    }
}
