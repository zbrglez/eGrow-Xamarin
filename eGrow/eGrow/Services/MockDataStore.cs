using eGrow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eGrow.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;
        readonly List<Plant> plants;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
            };
            plants = new List<Plant>()
            {
                new Plant { plantId = 1, plantName = "Vijolica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12 },
                new Plant { plantId = 1, plantName = "Vijolica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12 },
                new Plant { plantId = 1, plantName = "Vijolica", plantType = "NaTrankiRaster", optimalAmbientTemperatureCelsius = 17, optimalUvIndex = 3, optimalSolarRadiation = 2, optimalAmbientHumidityPercentage = 40, optimalSoilHumidityPercentage = 40, fullyGrownCm = 12 },

            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}