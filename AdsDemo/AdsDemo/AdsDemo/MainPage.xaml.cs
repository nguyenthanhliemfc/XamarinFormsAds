using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdsDemo
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void ButtonCallAds_OnClicked(object sender, EventArgs e)
	    {
	        DependencyService.Get<IInterstitialAds>().ShowAds();
        }
	}
}
