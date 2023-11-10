﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC06_MODULE06
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Accelerometer_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AccelerometerPage());
        }
        private async void Connectivity_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }
        private async void DeviceBattery_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DeviceBatteryPage());
        }
        private async void Geolocation_Page_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GeolocationPage());
        }
    }
}
