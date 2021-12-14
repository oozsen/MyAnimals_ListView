using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MyAnimals_ListView
{
    public partial class BasicList : ContentPage
    {
        public BasicList()
        {
            InitializeComponent();

            List<String> sampleList = new List<string>
            {
                "Student ID",
                "Name",
                "Surname",
                "Phone",
                "e-mail"
            };

            MyBasicList.ItemsSource = sampleList;
        }
    }
}
