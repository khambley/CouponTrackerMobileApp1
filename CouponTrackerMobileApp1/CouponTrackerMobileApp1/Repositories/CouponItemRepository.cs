using CouponTrackerMobileApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CouponTrackerMobileApp1.Repositories
{
    public class CouponItemRepository : ICouponItemRepository
    {
        public event EventHandler<CouponItem> OnItemAdded;
        public event EventHandler<CouponItem> OnItemUpdated;

        public Task AddItem(CouponItem item)
        {
            return null; //Just so it can build
        }

        public async Task AddOrUpdate(CouponItem item)
        {
            if(item.Id == 0)
            {
                await AddItem(item);
            }
            else
            {
                await UpdateItem(item);
            }
        }

        public Task<List<CouponItem>> GetItems()
        {
            throw new NotImplementedException();
        }

        public Task UpdateItem(CouponItem item)
        {
            throw new NotImplementedException();
        }
    }
}
