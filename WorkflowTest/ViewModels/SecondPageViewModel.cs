using System;
using System.Collections.ObjectModel;
using Prism.Windows.Mvvm;

namespace WorkflowTest.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel()
        {
            artists = new ObservableCollection<string>()
            {
                "Bruce Springsteen",
                "Pink Floyd",
                "Josh Ritter",
                "Aimee Mann",
                "Jonathon Coulton"
            };
        }

        private ObservableCollection<string> artists;
        public ObservableCollection<string> Artists
        {
            get => artists;
            set => SetProperty(ref artists, value);
        }
    }
}
