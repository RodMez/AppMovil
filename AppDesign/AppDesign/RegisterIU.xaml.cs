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
    public partial class RegisterIU : ContentPage
    {
        public RegisterIU()
        {
            InitializeComponent();
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopToRootAsync();

        }
    }
}