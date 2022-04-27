using CouponTrackerMobileApp1.Models;
using CouponTrackerMobileApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponItemAddEditViewModel : ViewModelBase
    {
        private readonly CouponItemRepository _repository;

        public CouponItem Item { get; set; }

        public CouponItemAddEditViewModel(CouponItemRepository repository)
        {
            _repository = repository;
            Item = new CouponItem() { ExpirationDate = DateTime.Now.AddDays(7) };
        }

        public ICommand Save => new Command(async () =>
        {
            await _repository.AddOrUpdate(Item);
            await Navigation.PopAsync();
        });
    }
}
