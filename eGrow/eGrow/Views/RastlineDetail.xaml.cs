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
    public partial class RastlineDetail : ContentPage
    {
        public RastlineDetail(string plantName, int optimalAmbientHumidityPercentage, int fullyGrownCm, int optimalUvIndex, int optimalLeafWetness)
        {
            InitializeComponent();
            naziv1.Text = plantName;
            naziv2.Text = plantName;
            velikost.Text = fullyGrownCm.ToString();
            uvi.Text = optimalUvIndex.ToString();
            vlaznost.Text = optimalLeafWetness.ToString();
            zrak.Text = optimalAmbientHumidityPercentage.ToString();
        }
    }
}