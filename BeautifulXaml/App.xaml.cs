﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BeautifulXaml
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new SkyAdventures();
            //MainPage = new SocialNetwork();
            //MainPage = new GreatPlaces();
            // MainPage = new SlidingUpPanel();

             MainPage = new TimeLine();
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
