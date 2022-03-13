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
    public partial class NapraveDetail : ContentPage
    {
        public NapraveDetail(string deviceGuid, int waterTankLevel, int fertilizerLevel)
        {
            InitializeComponent();
            naziv1.Text = deviceGuid;
            naziv2.Text = deviceGuid;
            watertank.Text = waterTankLevel.ToString();
            fertilizer.Text = fertilizerLevel.ToString();
        }
    }
}