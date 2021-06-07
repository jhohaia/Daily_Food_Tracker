using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Xamarin.Forms;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Daily_Food_Tracker.Models;
using System.Threading.Tasks;
using Daily_Food_Tracker.Services;

namespace Daily_Food_Tracker.ViewModels
{
    public class FoodPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Food> Food { get; set; }
        public ObservableRangeCollection<Grouping<string, Food>> FoodGroups { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public AsyncCommand AddCommand { get; }
        public AsyncCommand<Food> RemoveCommand { get; }

        public FoodPageViewModel()
        {
            ////HardCoded Values
            //Title = "Food";
            //Food = new ObservableRangeCollection<Food>();
            //FoodGroups = new ObservableRangeCollection<Grouping<string, Food>>();
            ////var image = "https://grandseasonscoquitlam.com/img/placeholders/xcomfort_food_placeholder.png,qv=1.pagespeed.ic.x100Yi-Swz.png";
            //Food.Add(new Food { FoodName="Apple",Calories=50});
            //Food.Add(new Food { FoodName = "Orange", Calories = 70});
            //Food.Add(new Food { FoodName = "Bread", Calories = 150});
            //FoodGroups.Add(new Grouping<string, Food>("Baking", new[] { Food[2] }));
            //FoodGroups.Add(new Grouping<string, Food>("Fruit", Food.Take(2)));
            //RefreshCommand = new AsyncCommand(Refresh);

            Title = "My Food";

                Food = new ObservableRangeCollection<Food>();
                RefreshCommand = new AsyncCommand(Refresh);
                AddCommand = new AsyncCommand(Add);
                RemoveCommand = new AsyncCommand<Food>(Remove);
        }
        async Task Add()
        {
            var foodid = await App.Current.MainPage.DisplayPromptAsync("ID", "ID");
            var foodname = await App.Current.MainPage.DisplayPromptAsync("Name", "Name");
            var alcohol = await App.Current.MainPage.DisplayPromptAsync("Alcohol", "Alcohol");
            var carbohydrates = await App.Current.MainPage.DisplayPromptAsync("Carbohydrates", "Carbohydrates");
            var calcium = await App.Current.MainPage.DisplayPromptAsync("Calcium", "Calcium");
            var cholesterol = await App.Current.MainPage.DisplayPromptAsync("Cholesterol", "Cholesterol");
            var calories = await App.Current.MainPage.DisplayPromptAsync("Calories", "Calories");
            var kilojule = await App.Current.MainPage.DisplayPromptAsync("KiloJule", "KiloJule");
            var fat = await App.Current.MainPage.DisplayPromptAsync("Fat", "Fat");
            var glucose = await App.Current.MainPage.DisplayPromptAsync("Glucose", "Glucose");
            var iron = await App.Current.MainPage.DisplayPromptAsync("Iron", "Iron");
            var lactose = await App.Current.MainPage.DisplayPromptAsync("Lactose", "Lactose");
            var magnesium = await App.Current.MainPage.DisplayPromptAsync("Magnesium", "Magnesium");
            var potassium = await App.Current.MainPage.DisplayPromptAsync("Potassium", "Potassium");
            var selenium = await App.Current.MainPage.DisplayPromptAsync("Selenium", "Selenium");
            var sodium = await App.Current.MainPage.DisplayPromptAsync("Sodium", "Sodium");
            var starch = await App.Current.MainPage.DisplayPromptAsync("Starch", "Starch");
            var sugars = await App.Current.MainPage.DisplayPromptAsync("Sugars", "Sugars");
            var water = await App.Current.MainPage.DisplayPromptAsync("Water", "Water");
            var zinc = await App.Current.MainPage.DisplayPromptAsync("Zinc", "Zinc");

            await FoodService.AddFood(foodid, foodname, alcohol, carbohydrates,
                calcium, cholesterol, calories, kilojule, fat, glucose, iron,
                lactose, magnesium, potassium, selenium, sodium, starch, sugars,
                water, zinc) ;
            await Refresh();
        }

        async Task Remove(Food food)
        {
            await FoodService.RemoveFood(food.ID);
            await Refresh();
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            Food.Clear();
            IsBusy = false;
            var foods = await FoodService.GetFood();
            Food.AddRange(foods);
        }
    }
}