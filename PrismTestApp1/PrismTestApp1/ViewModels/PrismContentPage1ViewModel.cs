using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTestApp1.ViewModels
{
	public class PrismContentPage1ViewModel : BindableBase, INavigatingAware
	{
        INavigationService _navigationService;
        public DelegateCommand ButtonClicked => new DelegateCommand(NavigateToMainPage);


        public string btnMessage
        {
            get { return _btnMessage; }
            set { SetProperty(ref _btnMessage, value); }
        }

        private string _btnMessage;

        public string titleMessage
        {
            get { return _titleMessage; }
            set { SetProperty(ref _titleMessage, value); }
        }

        private string _titleMessage;


        public PrismContentPage1ViewModel(INavigationService navigationService)            
        {
            _navigationService = navigationService;
            btnMessage = "Return to MainPage";
        }

        public void NavigateToMainPage()
        {
            _navigationService.NavigateAsync("MainPage");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            titleMessage = (string)parameters["title"];
        }
    }
}
