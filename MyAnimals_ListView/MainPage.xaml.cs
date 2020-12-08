using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAnimals_ListView.Data;
using Xamarin.Forms;

namespace MyAnimals_ListView
{
    public partial class MainPage : ContentPage
    {
        bool isEditing;

        public MainPage()
        {
            InitializeComponent();
            allAnimals.ItemsSource = AnimalRepository.Animals;
        }

        void OnEdit(System.Object sender, System.EventArgs e)
        {
            isEditing = !isEditing;
            ((ToolbarItem)sender).Text = isEditing ? "End Edit" : "Edit";
        }

        async void OnDelete(System.Object sender, System.EventArgs e)
        {
            var item = (MenuItem)sender;
            var animal = (Animal)item.BindingContext;
            await DeleteAnimalAsync(animal);
        }

        async Task<bool> DeleteAnimalAsync(Animal animal)
        {
            if (animal != null)
            {
                if (await this.DisplayAlert("Confirm", $"Are you sure you want to delete {animal.Name}?", "Yes", "No") == true)
                {
                    AnimalRepository.Animals.Remove(animal);
                    return true;
                }
            }
            return false;
        }

        async void OnItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            if (!isEditing)
            {
                var animalSelected = (Animal)e.Item;
                await this.Navigation.PushAsync(new AnimalDetails(animalSelected));
            }
        }

        async void OnItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (isEditing)
            {
                var animal = (Animal)e.SelectedItem;
                if (await DeleteAnimalAsync(animal))
                {
                    OnEdit(editButton, EventArgs.Empty);
                }
            }
        }
    }
}
