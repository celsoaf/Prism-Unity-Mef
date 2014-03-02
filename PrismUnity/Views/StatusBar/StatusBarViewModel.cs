using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;
using PrismUnity.Infrastructure.Events;

namespace PrismUnity.Views.StatusBar
{
    public class StatusBarViewModel : NotificationObject, IStatusBarViewModel
    {
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
