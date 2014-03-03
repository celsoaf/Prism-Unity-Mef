using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Events;
using PrismMEF.Module1.Models;
using System.Collections.ObjectModel;
using PrismMEF.Infrastructure.Events;
using System.ComponentModel.Composition;

namespace PrismMEF.Module1.Views.List
{
    [Export(typeof(IListViewModel))]
    public class ListViewModel : IListViewModel
    {
        private IEventAggregator _eventAggregator;

        [ImportingConstructor]
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
