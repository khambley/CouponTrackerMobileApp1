using CouponTrackerMobileApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CouponTrackerMobileApp1.Repositories
{
    public interface ICouponItemRepository
    {
        event EventHandler<CouponItem> OnItemAdded;
        event EventHandler<CouponItem> OnItemUpdated;

        Task<List<CouponItem>> GetItems();
        Task AddItem(CouponItem item);
        Task UpdateItem(CouponItem item);
        Task AddOrUpdate(CouponItem item);



    }
}
