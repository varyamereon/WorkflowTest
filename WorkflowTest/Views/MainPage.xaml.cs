using System;

using Windows.UI.Xaml.Controls;

using WorkflowTest.ViewModels;

namespace WorkflowTest.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
