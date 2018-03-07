using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismTestApp1.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        INavigationService _navigationService;

        public DelegateCommand DoSomething => new DelegateCommand(NavigateToContentPage);

        public string btnMessage
        {
            get { return _btnMessage; }
            set { SetProperty(ref _btnMessage, value); }
        }

        private string _btnMessage;

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            _navigationService = navigationService;
            btnMessage = "Click Me!?!?";
            Title = "Main Page";
        }

        public void NavigateToContentPage()
        {
            _navigationService.NavigateAsync("PrismContentPage1");
            btnMessage = "i was clicked!";
        }


    }
}
