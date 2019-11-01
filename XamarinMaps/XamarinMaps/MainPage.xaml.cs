using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XamarinMaps
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_open_coords_Clicked(object sender, EventArgs e)
        {
            //if (!double.TryParse(txt_latitude.Text, out double lat))
            //    return;
            //if (!double.TryParse(txt_longitude.Text, out double lng))
            //    return;

            //Map.OpenAsync(lat, lng, new MapLaunchOptions
            //{
            //    NavigationMode = NavigationMode.None
            //});
        }

        private void btnOpenMap_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MapPage());
        }
    }
}
