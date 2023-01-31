using System;
using System.Collections.Generic;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using Windows.Services.Maps;
using Windows.UI.Xaml.Controls;

namespace Neutron_Browser.ViewModels
{
    public class WebViewModel : ObservableObject
    {
        public static List<WebViewModel> All = new List<WebViewModel>();

        public WebView2 WebView;
        public CoreWebView2Profile UsrProfile;
        public CoreWebView2Settings Settings;


        public Guid Windows_ID;
        public Guid ID;

        public WebViewModel(WebView2 webview)
        {
            All.Add(this);

            WebView = webview;
        }

        //public static WebView2 ReturnActiveWebView()
        //{
            //WebView2 result = null;
            //Guid active_id;
            //active_id = MapManager.Current.Active_Tab_ID;

            //foreach (var item in All)
            //{
            //    if (item.ID == active_id)
            //    {
            //        result = item.WebView;
            //    }
            //}
            //return result;
        //}

        public Uri Source{get { return WebView.Source; }}
        
        public void SetSource(Uri source)
        {
            WebView.Source = source;
        }

        public bool CanGoBack
        {
            get { return WebView.CanGoBack; }
        }

        public bool CanGoForward
        {
            get { return WebView.CanGoForward; }
        }

        public void GoBack()
        {
            WebView.GoBack();
        }

        public void GoForward()
        {
            WebView.GoForward();
        }

        public void Refresh()
        {
            WebView.Reload();
        }

        public void SetNightMode(bool nightMode)
        {
            if(nightMode)
            {
                UsrProfile.PreferredColorScheme = CoreWebView2PreferredColorScheme.Light;
            }
            else
            {
                UsrProfile.PreferredColorScheme= CoreWebView2PreferredColorScheme.Dark;
            }
            
        }

        

    }
}
