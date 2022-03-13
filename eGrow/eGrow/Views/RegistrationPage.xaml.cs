using eGrow.Models;
using eGrow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eGrow.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrationPage : ContentPage
    {
        RegistrationViewModel vm;
        public RegistrationPage()
        {
            InitializeComponent();
            vm = new RegistrationViewModel();
        }


        //REGISTRACIJA click
        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (entry_uporabnisko == null || entry_geslo == null)
            {

            }
            else
            {
                User u = new User();
                u.username = entry_uporabnisko.Text;
                u.password = entry_geslo.Text;
                //email
                bool res = await vm.PostRegistracija(u);
                if (res == true)
                {
                    registracijatekst.Text = "Registracija uspešna.";
                }
                else
                {
                    registracijatekst.Text = "Registracija neuspešna.";
                }
            }
        }
    }
}