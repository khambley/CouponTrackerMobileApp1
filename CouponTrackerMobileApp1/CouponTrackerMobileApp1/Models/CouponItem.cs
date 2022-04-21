using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace CouponTrackerMobileApp1.Models
{
    public class CouponItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string StoreName { get; set; }
        public string MfrName { get; set; }
        public string ProductName { get; set; }
        public int ProductQty { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime StartingDate { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
