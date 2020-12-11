using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyAnimals_ListView
{
    public partial class StarterPage : ContentPage
    {
        public StarterPage()
        {
            InitializeComponent();
        }

        void Basic_Open(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new BasicList());
        }

        void Detailed_Open(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        void FromJson_Open(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FromJson());
        }
    }
}
