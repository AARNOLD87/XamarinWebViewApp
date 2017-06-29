using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using XamarinWebViewApp.Events;

namespace XamarinWebViewApp.ViewModels
{
    public class WebViewPageViewModel : BindableBase
    {

        #region Private Methods
        IEventAggregator _eventAggregator;
        #endregion

        #region Properties
        private string _url= "https://www.google.it";
        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                RaisePropertyChanged("Url");
            }
        }
        #endregion

        #region Constructors
        public WebViewPageViewModel(IEventAggregator eventAggregator)
        {
            this._eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<UrlChanged>().Subscribe(UrlChangedHandler); 
        }
        #endregion

        #region Private Methods
        private void UrlChangedHandler(string obj)
        {
            Url = obj;
        }
        #endregion
    }
}
