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
    public partial class LoginIU : ContentPage
    {
        public LoginIU()
        {
            InitializeComponent();

        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterIU());
        }

        private void LoginG_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Google", "Iniciando sesion con Google...", "OK!");
        }

        private void LoginT_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Twitter", "Iniciando sesion con Twitter...", "OK!");
        }

        private void LoginF_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Iniciar con Facebook", "Iniciando sesion con Facebook...", "OK!");
        }
    }
}