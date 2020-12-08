using System;
using System.Collections.Generic;
using MyAnimals_ListView.Data;
using Xamarin.Forms;

namespace MyAnimals_ListView
{
    public partial class AnimalDetails : ContentPage
    {
        public AnimalDetails(Animal animal)
        {
            BindingContext = animal;
            InitializeComponent();            
        }
    }
}
