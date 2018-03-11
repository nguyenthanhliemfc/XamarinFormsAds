using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdsDemo.Droid;
using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using AdsDemo;

[assembly: Xamarin.Forms.Dependency(typeof(InterstitialAds))]
namespace AdsDemo.Droid
{
    public class InterstitialAds : IInterstitialAds
    {
        private InterstitialAd ads;
        public void ShowAds()
        {
            try
            {
                var context = Android.App.Application.Context;
                ads = new InterstitialAd(context);

                ads.AdUnitId = "ca-app-pub-XXXXXXXXXXXXXXXXXXXXXXXXXXXX"; //Replace Video Ads

                var intlistener = new InterstitialAdListener(ads);
                intlistener.OnAdLoaded();
                ads.AdListener = intlistener;

                var requestBuilder = new AdRequest.Builder();
                ads.LoadAd(requestBuilder.Build());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Android Interstitial: " + ex.Message);
            }

        }
    }
}