using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MyAnimals_ListView
{
    public partial class FromJson : ContentPage
    {
        public ObservableCollection<Monkey> Monkeys { get; } = new ObservableCollection<Monkey>();

        private readonly HttpClient _httpClient = new HttpClient();

        public FromJson()
        {
            InitializeComponent();

            BindingContext = this;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if (!Monkeys.Any())
            {
                var monkeyJson = await _httpClient.GetStringAsync("https://montemagno.com/monkeys.json");

                var monkeys = JsonConvert.DeserializeObject<List<Monkey>>(monkeyJson);

                foreach (var m in monkeys)
                {
                    Monkeys.Add(m);
                }
            }
        }
    }
}
