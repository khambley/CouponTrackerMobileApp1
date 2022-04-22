using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;
using CouponTrackerMobileApp1.Repositories;
using CouponTrackerMobileApp1.ViewModels;

namespace CouponTrackerMobileApp1
{
    public abstract class Bootstrapper
    {
        protected ContainerBuilder ContainerBuilder { get; private set; }

        public Bootstrapper()
        {
            Initialize();
            FinishInitialization();
        }
        protected virtual void Initialize()
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            ContainerBuilder = new ContainerBuilder();
            foreach(var type in currentAssembly.DefinedTypes
                .Where(e => e.IsSubclassOf(typeof(Page))||
                       e.IsSubclassOf(typeof(ViewModelBase))))
                        {
                           ContainerBuilder.RegisterType(type.AsType());
                        }
            ContainerBuilder.RegisterType<CouponItemRepository>().SingleInstance();
        }


        private void FinishInitialization()
        {
            var container = ContainerBuilder.Build();
            Resolver.Initialize(container);
        }    
    }
}
