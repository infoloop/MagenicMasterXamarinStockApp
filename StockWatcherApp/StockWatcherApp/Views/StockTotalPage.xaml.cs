using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StockWatcherApp
{
    public partial class StockTotalPage : ContentPage
    {
        public StockTotalPage()
        {
            InitializeComponent();
            BindingContext = App.MainPageViewModel.Stocks;
            carouselView.ItemsSource = App.MainPageViewModel.Stocks;
        }
    }
}