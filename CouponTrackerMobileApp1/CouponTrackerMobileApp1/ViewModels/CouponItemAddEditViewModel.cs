using CouponTrackerMobileApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponItemAddEditViewModel : ViewModelBase
    {
        private readonly CouponItemRepository _repository;

        public CouponItemAddEditViewModel(CouponItemRepository repository)
        {
            _repository = repository;
        }
    }
}
