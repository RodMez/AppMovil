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
    public partial class PlayerIU : ContentPage
    {
        public PlayerIU()
        {
            InitializeComponent();
        }

        private void Slider_DragStarted(object sender, EventArgs e)
        {

        }
    }
}