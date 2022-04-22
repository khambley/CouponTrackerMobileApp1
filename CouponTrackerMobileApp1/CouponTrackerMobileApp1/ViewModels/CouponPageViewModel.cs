using CouponTrackerMobileApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        private async Task LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
