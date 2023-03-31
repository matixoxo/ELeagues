﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ELeagues
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LogIn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private async void LogOn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ELeaguesProj.LogonPage());
        }

        private async void About(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ELeagues.AboutUs());
        }
    }
}
