using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppDesign.Models
{
    public class MenuDynamic
    {
        public string Tittle { get; set; }

        public string ButtonText { get; set; }
        public ContentPage Pagina { get; set; }
        public object SelectionChanged { get; internal set; }
    }
}
