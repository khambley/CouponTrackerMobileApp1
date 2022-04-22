using Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace CouponTrackerMobileApp1.iOS
{
    public class Bootstrapper : CouponTrackerMobileApp1.Bootstrapper
    {
        public static void Init()
        {
            var instance = new Bootstrapper();
        }
    }
}