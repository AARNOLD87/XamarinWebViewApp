using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using XamarinWebViewApp.Events;

namespace XamarinWebViewApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {

        #region Private Methods
        IEventAggregator _eventAggregator;
        #endregion

        #region Commnads
        public DelegateCommand GoCommand { get; private set; }
        #endregion

        #region Properties
        private string _url;
        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                RaisePropertyChanged("Url");
            }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        #endregion



        #region Constructors
        public MainPageViewModel(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;
            this.GoCommand = new DelegateCommand(GoCommandMethod);
        }

        private void GoCommandMethod()
        {
            _eventAggregator.GetEvent<UrlChanged>().Publish(_url);
        }
        #endregion


        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
