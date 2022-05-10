using CouponTrackerMobileApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CouponTrackerMobileApp1.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CouponItemAddEditPage : ContentPage
    {
        public CouponItemAddEditPage(CouponItemAddEditViewModel viewModel)
        {
            InitializeComponent();
            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
        }

        void SwitchCell_OnChanged(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
        }
    }
}