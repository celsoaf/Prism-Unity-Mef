using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.ViewModel;
using PrismMEF.Infrastructure.Events;

namespace PrismMEF.Module2.Views.Details
{
    [Export(typeof(IDetailsViewModel))]
    public class DetailsViewModel : NotificationObject, IDetailsViewModel
    {
        [ImportingConstructor]
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
