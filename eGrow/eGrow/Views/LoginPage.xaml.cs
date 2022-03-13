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
    public partial class LoginPage : ContentPage
    {
        LoginViewModel vm;
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext =vm= new LoginViewModel();
        }
        // Prijava- click prijava
        private async void Button_Prijava(object sender, EventArgs e)
        {
            if (entry_uporabnisko.Text == "admin" && entry_geslo.Text == "admin")
            {
                prijavatekst.Text = "Prijava uspešna.";
                App.Current.MainPage = new AppShell();
            }
            else
            {
                if (entry_uporabnisko == null || entry_geslo == null)
                {

                }
                else
                {
                    User u = new User();
                    u.username = entry_uporabnisko.Text;
                    u.password = entry_geslo.Text;
                    bool res = await vm.PostDataPrijava(u);
                    if (res == true)
                    {
                        prijavatekst.Text = "Prijava uspešna.";
                        App.Current.MainPage = new AppShell();
                    }
                    else
                    {
                        prijavatekst.Text = "Prijava neuspešna.";
                    }
                }
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage(), true);
        }
    }
}