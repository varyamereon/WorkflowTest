using System;

using Windows.UI.Xaml.Controls;

using WorkflowTest.ViewModels;

namespace WorkflowTest.Views
{
    public sealed partial class SecondPagePage : Page
    {
        private SecondPageViewModel ViewModel => DataContext as SecondPageViewModel;

        public SecondPagePage()
        {
            InitializeComponent();
        }
    }
}
