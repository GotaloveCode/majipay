﻿using System;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;
using Windows.UI.Popups;

namespace MajiPay
{
    public static class UIHelper
    {
        public static string baseUrl = "http://sample.masterpiecenet.co.ke/"; //"http://localhost/majipay/";

        public static async Task ToggleProgressBar(bool toggle, string message = "")
        {
            var statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();

            if (toggle)
            {
                statusBar.ProgressIndicator.Text = message;
                await statusBar.ProgressIndicator.ShowAsync();
            }
            else
            {
                await statusBar.ProgressIndicator.HideAsync();
            }
        }

        public static async Task ShowAlert(string message, string title = "")
        {
            MessageDialog dialog = new MessageDialog(message, title);
            await dialog.ShowAsync();
        }

        public static bool HasInternetConnection()
        {
            ConnectionProfile connectionProfile = NetworkInformation.GetInternetConnectionProfile();
            return (connectionProfile != null && connectionProfile.GetNetworkConnectivityLevel() == NetworkConnectivityLevel.InternetAccess);
        }
    }
}
