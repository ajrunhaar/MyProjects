using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EntryManager.Views
{
    /// <summary>
    /// Interaction logic for MainEntryView.xaml
    /// </summary>
    public partial class MainEntryView : Window
    {
        ViewModels.MainEntryViewModel _viewModel;
        public MainEntryView()
        {
            InitializeComponent();
            _viewModel = (ViewModels.MainEntryViewModel)base.DataContext;
        }
    }
}
