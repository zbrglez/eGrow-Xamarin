using eGrow.Models;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eGrow.ViewModels
{
    public class NapraveViewModel : BaseViewModel
    {
        public ObservableCollection<Device> naprave { get; set; }
        public AsyncCommand RefreshCommand { get; }

        public NapraveViewModel()
        {
            naprave = new ObservableCollection<Device>();
            naprave.Add(new Device { deviceId = 1, waterTankLevel = 2, fertilizerLevel = 2, deviceGuid = "Naprava 1" });
            naprave.Add(new Device { deviceId = 1, waterTankLevel = 2, fertilizerLevel = 2, deviceGuid = "Naprava 2" });
            naprave.Add(new Device { deviceId = 1, waterTankLevel = 2, fertilizerLevel = 2, deviceGuid = "Naprava 3" });
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
