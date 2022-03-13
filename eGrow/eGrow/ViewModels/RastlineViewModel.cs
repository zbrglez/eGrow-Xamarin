using eGrow.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eGrow.ViewModels
{
    public class RastlineViewModel : BaseViewModel
    {
        public ObservableCollection<Plant> plants { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public RastlineViewModel()
        {
            plants = new ObservableCollection<Plant>();
            plants.Add(new Plant { plantId = 1, plantName = "Vijolica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12, optimalLeafWetness = 54 });
            plants.Add(new Plant { plantId = 1, plantName = "Vrtnica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12, optimalLeafWetness = 54 });
            plants.Add(new Plant { plantId = 1, plantName = "Trobentica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12, optimalLeafWetness = 54 });
            RefreshCommand = new AsyncCommand(Refresh);


        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}
