using StockWatcherApp.Models;
using StockWatcherApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockWatcherApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = (Color)App.Current.Resources["moneyGreen"]
            };
        }

        private static MainPageViewModel _mainPageViewModel;
        public static MainPageViewModel MainPageViewModel
        {
            get
            {
                if (_mainPageViewModel == null)
                    _mainPageViewModel = new MainPageViewModel();
                return _mainPageViewModel;
            }
            set { _mainPageViewModel = value; }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
