using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using PrismUnity.Module1.Models;
using Microsoft.Practices.Prism.Events;
using PrismUnity.Infrastructure.Events;

namespace PrismUnity.Module1.Views.List
{
    public class ListViewModel:IListViewModel
    {
        private IEventAggregator _eventAggregator;

        public ListViewModel(IListView view, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            View = view;
            View.DataContext = this;
        }

        public IListView View { get; set; }

        public ObservableCollection<ListItem> Items { get; set; }

        private ListItem _SelectedItem;
        public ListItem SelectedItem
        {
            get
            {
                return _SelectedItem;
            }
            set
            {
                _SelectedItem = value;

                _eventAggregator.GetEvent<ItemSelectedEvent>().Publish(
                    value != null ? value.Name : null);
            }
        }
    }
}
