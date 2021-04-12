using StockWatcherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockWatcherApp
{
    public partial class AddStockPage : ContentPage
    {
        public AddStockPage()
        {
            InitializeComponent();
        }

        async void OnAddClicked(object sender, EventArgs e)
        {
            var stockItem = (StockItem)BindingContext;

            App.MainPageViewModel.AddStock(stockItem);
            await Navigation.PopAsync();
        }
    }
}