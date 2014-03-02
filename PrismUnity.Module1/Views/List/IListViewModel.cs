using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrismUnity.Module1.Models;
using System.Collections.ObjectModel;

namespace PrismUnity.Module1.Views.List
{
    public interface IListViewModel
    {
        IListView View { get; set; }

        ObservableCollection<ListItem> Items { get; set; }
        ListItem SelectedItem { get; set; }
    }
}
