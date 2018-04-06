using TestApp.ViewModels;
using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestApp.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    [MvxContentPagePresentation(WrapInNavigationPage = true)]
    public partial class AboutPage : MvxContentPage<AboutViewModel>
	{
		public AboutPage ()
		{
			InitializeComponent ();
		}
	}
}