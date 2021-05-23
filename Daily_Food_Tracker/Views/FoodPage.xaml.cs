using Daily_Food_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Food_Tracker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage : ContentPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var food = ((ListView)sender).SelectedItem as Food;
            if (food == null)
                return;

            await DisplayAlert("Food Added", food.FoodName, "OK");
        }

        private  void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var food = ((ListView)sender).SelectedItem as Food;
            //if (food == null)
            //    return;

            //await DisplayAlert("Food Selected", food.FoodName, "OK");

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}