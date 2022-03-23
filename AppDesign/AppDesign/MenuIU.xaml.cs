using AppDesign.Models;
using AppDesign.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuIU : ContentPage
    {
        public ObservableCollection<MenuDynamic> MenuDynamics { get; set; }
        public MenuIU()
        {
            InitializeComponent();
            MenuDynamics = new ObservableCollection<MenuDynamic>()
            {
                new MenuDynamic
                {
                     Tittle ="Music Tracks",
                     ButtonText ="Ir a Music Tracks",
                     Pagina = new TracksIU()
                },
                 new MenuDynamic
                {
                    Tittle ="Music Player",
                     ButtonText ="Ir a Music Player",
                     Pagina = new PlayerIU()
                },
                  new MenuDynamic
                {
                    Tittle ="Inbox Messages",
                     ButtonText ="Ir a Inbox Messages",
                    Pagina = new InboxIU()
                },
                     new MenuDynamic
                {
                    Tittle ="Contact List",
                     ButtonText ="Ir a Contact List",
                    Pagina = new ContactIU()
                },
                        new MenuDynamic
                {
                    Tittle ="Friends Feed",
                     ButtonText ="Ir a Friends Feed",
                    Pagina = new FriendsIU()
                },

                           new MenuDynamic
                {
                    Tittle ="Calendar",
                     ButtonText ="Ir a Calendar",
                    Pagina = new CalendarIU()
                },

                            new MenuDynamic
                {
                    Tittle ="Photo e Image",
                    ButtonText ="Ir a Photo e Image",
                    Pagina = new PhotosIU()
                },
                            new MenuDynamic
                {
                    Tittle ="Write Post",
                    ButtonText ="Ir a Write Post",
                    Pagina = new WriteIU()
                },
                            new MenuDynamic
                {
                    Tittle ="Account Settings",
                    ButtonText ="Ir a Account Settings",
                    Pagina = new SettingsIU()
                },

            };
            this.BindingContext = this;
        }
        private  void GoToPage(Page page)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(page);
            App.FlyoutP.IsPresented = false;
        }
        private  void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuDynamic element = (MenuDynamic)e.CurrentSelection.FirstOrDefault();

            if (element!=null)
            {              
                GoToPage(element.Pagina);
            }
           
            ((CollectionView)sender).SelectedItem = null;
            
           

        }

       



    }
}