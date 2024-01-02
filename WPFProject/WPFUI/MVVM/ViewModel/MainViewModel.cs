using WPFUI.Core;

namespace WPFUI.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand FeatureViewCommand { get; set; }
        public HomeViewModel HomeVM;
        public DiscoveryViewModel DiscoveryVM;
        public FeatureViewModel FeatureVM;
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            FeatureVM = new FeatureViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(x => { 
                CurrentView = HomeVM;
            });
            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentView = DiscoveryVM;
            });
            FeatureViewCommand = new RelayCommand(o =>
            {
                CurrentView = FeatureVM;
            });
        }
    }
}
