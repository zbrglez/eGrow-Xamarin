using eGrow.Models;
using eGrow.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eGrow.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        //PRIJAVA POST 
        public async Task<bool> PostDataPrijava(User u)
        {
            try
            {
                HttpClient client = new HttpClient();
                Uri uri = new Uri("https://localhost:44319/api/Login");

                string json = JsonConvert.SerializeObject(u);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(uri, content);

                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        private async void OnLoginClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
