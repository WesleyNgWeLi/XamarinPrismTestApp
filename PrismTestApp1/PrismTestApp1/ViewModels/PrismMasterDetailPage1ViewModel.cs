using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismTestApp1.ViewModels
{
	public class PrismMasterDetailPage1ViewModel : BindableBase
	{
        INavigationService _navigationService;

        public DelegateCommand<string> NavigateCommand { get; set; }

        public PrismMasterDetailPage1ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(Navigate);
        }


        private void Navigate(string name)
        {
            _navigationService.NavigateAsync("NavigationPage/" + name);
        }
    }
}
