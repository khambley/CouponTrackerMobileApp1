using CouponTrackerMobileApp1.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CouponTrackerMobileApp1.Pages;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Linq;
using CouponTrackerMobileApp1.Models;

namespace CouponTrackerMobileApp1.ViewModels
{
    public class CouponPageViewModel : ViewModelBase
    {
        private readonly CouponItemRepository _repository;

        public ObservableCollection<CouponItemViewModel> Items { get; set; }

        public CouponItemViewModel SelectedItem {
            get { return null; }
            set
            {
                Device.BeginInvokeOnMainThread(async () => await NavigateToItem(value));
                RaisePropertyChanged(nameof(SelectedItem));
            }
        }

        public CouponPageViewModel(CouponItemRepository repository)
        {
            // hook up events from the repository to know when data changes
            // the coupon list will update automatically.
            repository.OnItemAdded += (sender, item) => Items.Add(CreateCouponItemViewModel(item));
            repository.OnItemUpdated += (sender, item) => Task.Run(async () => await LoadData());

            _repository = repository;

            Task.Run(async () => await LoadData());
        }
        private async Task NavigateToItem(CouponItemViewModel item)
        {
            if(item == null)
            {
                return;
            }

            var itemView = Resolver.Resolve<CouponItemAddEditPage>();

            var vm = itemView.BindingContext as CouponItemAddEditViewModel;

            vm.Item = item.Item;

            await Navigation.PushAsync(itemView);
        }
        public ICommand AddItem => new Command(async () =>
        {
            var couponItem = Resolver.Resolve<CouponItemAddEditPage>();
            await Navigation.PushAsync(couponItem);
        });

        private async Task LoadData()
        {
            // get items from repository
            var items = await _repository.GetItems();

            // **best practice** - wrap each coupon item in a CouponItemViewModel
            // (adds properties specific to view that's why not using CouponItem.cs)
            var couponItemViewModels = items.Select(i => CreateCouponItemViewModel(i));


            Items = new ObservableCollection<CouponItemViewModel>(couponItemViewModels);
        }

        private CouponItemViewModel CreateCouponItemViewModel(CouponItem couponItem)
        {
            var itemViewModel = new CouponItemViewModel(couponItem);
            itemViewModel.ItemStatusChanged += ItemStatusChanged;
            return itemViewModel;
        }

        private void ItemStatusChanged(object sender, EventArgs e)
        {

        }
    }
}
