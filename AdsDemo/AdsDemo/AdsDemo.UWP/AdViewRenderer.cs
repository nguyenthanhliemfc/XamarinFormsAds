using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;
using AdsDemo;
using AdsDemo.UWP;
using Microsoft.Advertising.WinRT.UI;
using Xamarin.Forms.Platform.UWP;

[assembly:ExportRenderer(typeof(AdControlView),typeof(AdViewRenderer))]
namespace AdsDemo.UWP
{
    public class AdViewRenderer: ViewRenderer<AdControlView, AdControl>
    {
        //Relace by your Ads ID Banner
        string bannerId = "XXXXXXX";
        string applicationID = "XXXXXXXXXXXX";

        AdControl adView;
        
        void CreateNativeAdControl()
        {
            if (adView != null)
                return;

            var width = 300;
            var height = 50;

            if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Desktop")
            {
                width = 728;
                height = 90;
            }

            // Setup your BannerView, review AdSizeCons class for more Ad sizes. 

            adView = new AdControl
            {
                ApplicationId = applicationID,
                AdUnitId = bannerId,
                HorizontalAlignment = Windows.UI.Xaml.HorizontalAlignment.Center,
                VerticalAlignment = Windows.UI.Xaml.VerticalAlignment.Bottom,
                Height = height,
                Width = width
            };
        }

        protected override void OnElementChanged(ElementChangedEventArgs<AdControlView> e)
        {
            base.OnElementChanged(e);
            try
            {
                if (Control == null)
                {
                    CreateNativeAdControl();
                    SetNativeControl(adView);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
