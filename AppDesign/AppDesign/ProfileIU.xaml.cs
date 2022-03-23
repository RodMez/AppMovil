using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfileIU : ContentPage
    {
        public ProfileIU()
        {
            InitializeComponent();
        }

        private async void Go_Tracks_Clicked(object sender, EventArgs e)
        {
            await App.FlyoutP.Detail.Navigation.PushAsync(new TracksIU());
        }
    }
}