using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautifulXaml
{
    public partial class TimeLine : ContentPage
    {
        public TimeLine()
        {
            InitializeComponent();

            BindingContext = DataFactory.Classes;
        }

        private void timelineListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            timelineListView.SelectedItem = null;
        }
    }
}
