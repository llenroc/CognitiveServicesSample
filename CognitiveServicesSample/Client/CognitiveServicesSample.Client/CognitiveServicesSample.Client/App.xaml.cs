﻿using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using CognitiveServicesSample.Client.Views;
using Xamarin.Forms;

namespace CognitiveServicesSample.Client
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}