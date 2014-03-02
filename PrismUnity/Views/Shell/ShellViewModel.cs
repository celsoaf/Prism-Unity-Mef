using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Commands;
using PrismUnity.Infrastructure.Events;

namespace PrismUnity.Views.Shell
{
    public class ShellViewModel : IShellViewModel
    {
        public ShellViewModel(IShellView view, IEventAggregator eventAggregator)
        {
            View = view;
            View.DataContext = this;

            ExitCommand = new DelegateCommand(() =>
                eventAggregator.GetEvent<ExitApplicationEvent>().Publish(null));
        }

        public IShellView View { get; set; }

        public ICommand ExitCommand { get; set; }
    }
}
