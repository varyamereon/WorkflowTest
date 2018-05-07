using Windows.UI.Xaml.Controls;
using WorkflowTest.ViewModels;

namespace WorkflowTest.Views
{
    public sealed partial class FourthPagePage : Page
    {
        private FourthPageViewModel ViewModel => DataContext as FourthPageViewModel;

        public FourthPagePage()
        {
            this.InitializeComponent();
        }
    }
}
