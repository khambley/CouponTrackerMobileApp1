using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace CouponTrackerMobileApp1.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //makes GUI aware of any property changes
        public void RaisePropertyChanged(params string[] propertyNames)
        {
            foreach (var property in propertyNames)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public INavigation Navigation { get; set; }
    }
}
