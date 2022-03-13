using eGrow.Models;
using eGrow.ViewModels;
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
    public partial class Rastline : ContentPage
    {
        public ObservableCollection<Plant> plants;
        public Rastline()
        {
            InitializeComponent();
            this.BindingContext = new RastlineViewModel();
            plants = (ObservableCollection<Plant>)plantslist.ItemsSource;
        }

        private async void plantslist_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var details = e.Item as Plant;
            await Navigation.PushAsync(new RastlineDetail(details.plantName, details.optimalLeafWetness, details.fullyGrownCm, details.optimalUvIndex, details.optimalAmbientHumidityPercentage));
        }
    }
}