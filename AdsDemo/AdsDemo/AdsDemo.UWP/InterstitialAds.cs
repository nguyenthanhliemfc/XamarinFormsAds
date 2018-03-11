using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdsDemo.UWP;
using Microsoft.Advertising.WinRT.UI;

[assembly: Xamarin.Forms.Dependency(typeof(InterstitialAds))]
namespace AdsDemo.UWP
{
    public class InterstitialAds:IInterstitialAds
    {
        private InterstitialAd interstitialAd;
        public void ShowAds()
        {
            // Instantiate the interstitial video ad

            interstitialAd = new InterstitialAd();

            // Attach event handlers

            interstitialAd.ErrorOccurred += OnAdError;

            interstitialAd.AdReady += OnAdReady;

            interstitialAd.Cancelled += OnAdCancelled;

            interstitialAd.Completed += OnAdCompleted;

            interstitialAd.RequestAd(AdType.Display, "XXXXXXXXXXX", "XXXXX"); //Replace your Ads ID
        }
        private void OnAdCompleted(object sender, object e)
        {
            //For easy Debug Ads
        }

        private void OnAdCancelled(object sender, object e)
        {
            //For easy Debug Ads
        }

        private void OnAdReady(object sender, object e)
        {
            interstitialAd.Show();
        }

        private void OnAdError(object sender, AdErrorEventArgs e)
        {
            Debug.WriteLine("Microsoft InterstitialAd Ads Error: " + e.ErrorMessage);
            //interstitialAd.RequestAd(AdType.Display, "9ngb2hgx2bqp", "352373");
            //VungleAds ads = new VungleAds();
            //ads.ShowAds();

        }
    }
}
