using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using PrismMEF.Infrastructure.Events;

namespace PrismMEF.Views.Shell
{
    [Export(typeof(IShellViewModel))]
    public class ShellViewModel : IShellViewModel
    {
        [ImportingConstructor]
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
