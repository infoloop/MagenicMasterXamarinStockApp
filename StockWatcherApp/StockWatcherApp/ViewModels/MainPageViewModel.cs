using StockWatcherApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace StockWatcherApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<StockItem> _stocks = new ObservableCollection<StockItem>();
        public ObservableCollection<StockItem> Stocks {
            get { return _stocks; }
            set { 
                _stocks = value;
                NotifyPropertyChanged("ValueOfAllStock");
            }
        } 

        public void AddStock (StockItem stock)
        {
            _stocks.Add(stock);
            NotifyPropertyChanged("ValueOfAllStock");
        }

        public virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }

        public double ValueOfAllStock
        {
            get { 
                double sum = (from x in Stocks select x.TotalValue).Sum();
                return sum;
            }
        }

    }
}
