using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Prism.Navigation;

namespace PrismTestApp1.Views
{
	public partial class MainPage : ContentPage
	{
        

		public MainPage ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args)
        {

            Console.WriteLine("Button was Clicked =O Blubbbb~~~");
        }
    }
}