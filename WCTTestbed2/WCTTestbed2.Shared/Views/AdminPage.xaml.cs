using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using WCTTestbed2.Shared.Helpers;
using WCTTestbed2;
using Microsoft.Toolkit.Uwp.SampleApp.Data;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WCTTestbed2.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminPage : Page
    {
        private DataGridDataSource viewModel = new DataGridDataSource();
       private  ObservableCollection<string> rights = new ObservableCollection<string>();
        public AdminPage()
        {
            this.InitializeComponent();
            Loading += AdminPage_Loading;
        //    _navigationSyncHelper = new NavigationSyncHelper(
        //     NavView,
        //     ContentFrame,
        //     new Dictionary<string, Type>()
        //     {
        //            {"HomePage",        typeof(HomePage) },
        //            {"TimeEntryPage",   typeof(TimeEntryPage) },
        //            {"ReportsPage",     typeof(ReportsPage) },
        //            {"AdminPage",       typeof(AdminPage) },
        //            {"AboutPage",       typeof(AboutPage) },
        //     });
        }

        private async void AdminPage_Loading(object sender, object args)
        {
            dataGrid.ItemsSource = await viewModel.GetDataAsync();


            rights.Add("Admin");
            rights.Add("Readonly");
            rights.Add("Writeonly");
            rights.Add("ModifyOnly");
            rights.Add("None");
            rights.Add("Read & Write");
            rights.Add("Read & Modify");
            rights.Add("Write & Modify");

        }
    }
}
