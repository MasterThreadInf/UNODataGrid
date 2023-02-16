using Microsoft.Toolkit.Uwp.SampleApp.Data;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using WCTTestbed2.Shared.Helpers;
using WCTTestbed2.Shared.Views;
using Windows.Foundation;
using Windows.Foundation.Collections;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WCTTestbed2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
    
        private NavigationSyncHelper _navigationSyncHelper;
        public MainPage()
        {
            this.InitializeComponent();

            Loading += MainPage_Loading;
            _navigationSyncHelper = new NavigationSyncHelper(
            NavView,
            ContentFrame,
              new Dictionary<string, Type>()
              {
                    {"HomePage",        typeof(HomePage) },
                    {"TimeEntryPage",   typeof(TimeEntryPage) },
                    {"ReportsPage",     typeof(ReportsPage) },
                    {"AdminPage",       typeof(AdminPage) },
                    {"AboutPage",       typeof(AboutPage) },
              });
        }

        private async void MainPage_Loading(object sender, object args)
        {
            ContentFrame.Navigate(typeof(AdminPage), null, new EntranceNavigationTransitionInfo());

        }
        private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            // log errors

        }
    }
}
