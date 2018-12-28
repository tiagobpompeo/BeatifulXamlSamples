using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautifulXaml
{
    public partial class GreatPlaces : ContentPage
    {
        public GreatPlaces()
        {
            InitializeComponent();
            BindingContext = DataFactory.Places;    

        }
    }
}
