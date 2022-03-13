using eGrow.ViewModels;
using eGrow.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eGrow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Naprave : ContentPage
    {
        public ObservableCollection<Models.Device> naprave;

        //public ObservableCollection<Device> naprave;
        public Naprave()
        {
            InitializeComponent();
            this.BindingContext = new NapraveViewModel();
            naprave = (ObservableCollection<Models.Device>)plantslist.ItemsSource;
        }

        private async void plantslist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Models.Device;
            await Navigation.PushAsync(new NapraveDetail(details.deviceGuid, details.waterTankLevel, details.fertilizerLevel));

        }
    }
}