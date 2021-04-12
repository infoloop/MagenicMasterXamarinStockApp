using System;
using StockWatcherApp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using StockWatcherApp.Models;

namespace StockWatcherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public ViewModels.MainPageViewModel ViewModel;


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ViewModel = App.MainPageViewModel;
            listView.ItemsSource = ViewModel.Stocks;
            this.BindingContext = ViewModel;
        }

        async void OnStockAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddStockPage
            {
                BindingContext = new StockItem()
            });
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new StockTotalPage
                {
                    BindingContext = ViewModel.Stocks
                });  
            }
        }
    }
}
