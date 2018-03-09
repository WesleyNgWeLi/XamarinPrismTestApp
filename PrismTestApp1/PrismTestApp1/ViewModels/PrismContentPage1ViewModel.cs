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


        public string titleMessage
        {
            get { return _titleMessage; }
            set { SetProperty(ref _titleMessage, value); }
        }

        private string _titleMessage;


        public PrismContentPage1ViewModel()
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            titleMessage = (string)parameters["title"];
        }
    }
}
