using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppDesign
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new MenuIU();
            this.Detail = new NavigationPage(new ProfileIU())
            {
                BarBackgroundColor = Color.DarkBlue,
            };
            App.FlyoutP = this;
        }
    }
}
