using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Ads;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Debug = System.Diagnostics.Debug;

namespace AdsDemo.Droid
{
    public class InterstitialAdListener: AdListener
    {
        readonly InterstitialAd _ad;

        public InterstitialAdListener(InterstitialAd ad)
        {
            _ad = ad;
        }

        public override void OnAdLoaded()
        {
            base.OnAdLoaded();
            try
            {
                if (_ad.IsLoaded)
                {
                    _ad.Show();
                }
                else
                {
                    Debug.WriteLine("Android Interstitial listener: " + _ad.IsLoaded);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Android Interstitial Try Catch listener: " + ex.Message);
            }
        }
    }
}