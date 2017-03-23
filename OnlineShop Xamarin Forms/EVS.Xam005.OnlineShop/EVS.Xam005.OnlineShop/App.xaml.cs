﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EVS.Xam005.OnlineShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new EVS.Xam005.OnlineShop.MainPage();
            MainPage = new EVS.Xam005.OnlineShop.UIPages.LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
