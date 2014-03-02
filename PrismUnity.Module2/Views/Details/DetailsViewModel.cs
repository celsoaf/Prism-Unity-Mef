using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.ViewModel;
using Microsoft.Practices.Prism.Events;
using PrismUnity.Infrastructure.Events;

namespace PrismUnity.Module2.Views.Details
{
    public class DetailsViewModel : NotificationObject, IDetailsViewModel
    {
        public DetailsViewModel(IDetailsView view, IEventAggregator eventAggregator)
        {
            View = view;
            View.DataContext = this;

            eventAggregator.GetEvent<ItemSelectedEvent>().Subscribe(s => Description = s);
        }

        public IDetailsView View { get; set; }

        private string _Description;
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;

                RaisePropertyChanged(() => Description);
            }
        }
    }
}
