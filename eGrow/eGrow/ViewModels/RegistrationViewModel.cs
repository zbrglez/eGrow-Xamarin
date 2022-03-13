using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using eGrow.Models;
using eGrow.Views;
using Newtonsoft.Json;

namespace eGrow.ViewModels
{
    public class RegistrationViewModel : BaseViewModel
    {
        //REGISTRACIJA uporabnika API
        public async Task<bool> PostRegistracija(User upor)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                Uri uri = new Uri("https://localhost:44319/api/Register");

                string json = JsonConvert.SerializeObject(upor);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(uri, content);

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
    }
}
