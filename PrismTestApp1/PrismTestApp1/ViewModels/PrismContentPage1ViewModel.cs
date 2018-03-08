using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTestApp1.ViewModels
{
	public class PrismContentPage1ViewModel : BindableBase
	{


        //this is how you bind a XAML Command
        public DelegateCommand DoSomething => new DelegateCommand(NavigateToContentPage);

        //this is how you bind a variable in XAML
        public string btnMessage
        {
            get { return _btnMessage; }
            set { SetProperty(ref _btnMessage, value); }
        }

        private string _btnMessage;


        public void NavigateToContentPage()
        {
            _navigationService.NavigateAsync("PrismContentPage1");
            btnMessage = "i was clicked!";
        }

        public PrismContentPage1ViewModel(INavigationService navigationService)
        {

        }
	}
}
