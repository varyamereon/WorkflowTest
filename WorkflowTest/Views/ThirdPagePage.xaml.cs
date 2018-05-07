using System;

using Windows.UI.Xaml.Controls;

using WorkflowTest.ViewModels;

namespace WorkflowTest.Views
{
    public sealed partial class ThirdPagePage : Page
    {
        private ThirdPageViewModel ViewModel => DataContext as ThirdPageViewModel;

        public ThirdPagePage()
        {
            InitializeComponent();
        }
    }
}
