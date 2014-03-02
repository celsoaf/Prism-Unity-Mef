using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using PrismUnity.Module1.Models;

namespace PrismUnity.Module1.Views.List
{
    public class ListViewModel:IListViewModel
    {
        public ListViewModel(IListView view)
        {
            View = view;
            View.DataContext = this;
        }

        public IListView View { get; set; }

        public ObservableCollection<ListItem> Items { get; set; }

        public ListItem SelectedItem { get; set; }
    }
}
