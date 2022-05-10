using CouponTrackerMobileApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponItemViewModel : ViewModelBase
    {
        public CouponItemViewModel(CouponItem item)
        {
            Item = item;
            AmountString = item.Amount.ToString("C2");
        }

        public event EventHandler ItemStatusChanged;

        public CouponItem Item { get; private set; }

        public string StatusText => Item.IsUsed ? "Used" : "Available";

        public string AmountString { get; set; }

        public ICommand ToggleIsUsed => new Command((arg) =>
        {
            Item.IsUsed = !Item.IsUsed;
            ItemStatusChanged?.Invoke(this, new EventArgs());
        });
    }
}
