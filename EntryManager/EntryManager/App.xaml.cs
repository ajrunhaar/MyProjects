using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace EntryManager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void EntryManager_OnStartup(object sender, StartupEventArgs args)
        {
            Views.MainEntryView mainViewEntry = new Views.MainEntryView();
            mainViewEntry.Show();
        }

        private void EntryManager_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs args)
        {
            MessageBox.Show(args.Exception.Message);
            args.Handled = true;
        }
    }
}
