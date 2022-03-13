using eGrow.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace eGrow.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}