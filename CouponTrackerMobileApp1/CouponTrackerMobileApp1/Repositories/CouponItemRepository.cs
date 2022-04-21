using CouponTrackerMobileApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using CouponTrackerMobileApp1.Models;
using System.IO;

namespace CouponTrackerMobileApp1.Repositories
{
    public class CouponItemRepository : ICouponItemRepository
    {
        private SQLiteAsyncConnection _connection;

        private async Task CreateConnection()
        {
            if (_connection != null)
            {
                return;
            }
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var datebasePath = Path.Combine(documentPath, "CouponItems.db");

            _connection = new SQLiteAsyncConnection(datebasePath);

            await _connection.CreateTableAsync<CouponItem>();

            if(await _connection.Table<CouponItem>().CountAsync() == 0)
            {
                await _connection.InsertAsync(new CouponItem()
                {
                    ExpirationDate = DateTime.Now.AddDays(15),
                    StoreName = "Test Store",
                    ProductName = "Test Product",
                    ProductQty = 1,
                    Amount = 3.00M,
                    DateAdded = DateTime.Now,
                    StartingDate = DateTime.Now,
                    Description = "save off any test product 12 oz or higher",
                    Category = "Health"
                });
            }
        }

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
