using CouponTrackerMobileApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CouponTrackerMobileApp1.Pages;
using Xamarin.Forms;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponPageViewModel : ViewModelBase
    {
        private readonly CouponItemRepository _repository;

        

        public CouponPageViewModel(CouponItemRepository repository)
        {
            _repository = repository;
            Task.Run(async () => await LoadData());
        }

        public ICommand AddItem => new Command(async () =>
        {
            var couponItem = Resolver.Resolve<CouponItemAddEditPage>();
            await Navigation.PushAsync(couponItem);
        });
        private async Task LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
