using CouponTrackerMobileApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponItemViewModel : ViewModelBase
    {
        public CouponItemViewModel(CouponItem item) => Item = item;

        public event EventHandler ItemStatusChanged;

        public CouponItem Item { get; private set; }

        public string StatusText => Item.IsUsed ? "Available" : "Used";
    }
}
