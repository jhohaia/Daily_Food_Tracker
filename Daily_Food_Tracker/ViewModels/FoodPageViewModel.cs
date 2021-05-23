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

namespace Daily_Food_Tracker.ViewModels
{
    public class FoodPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Food> Food { get; set; }
        public ObservableRangeCollection<Grouping<string, Food>> FoodGroups { get; set; }
        public AsyncCommand RefreshCommand { get; }
        public FoodPageViewModel()
        {
            Title = "Food";

            Food = new ObservableRangeCollection<Food>();
            FoodGroups = new ObservableRangeCollection<Grouping<string, Food>>();
            var image = "https://grandseasonscoquitlam.com/img/placeholders/xcomfort_food_placeholder.png,qv=1.pagespeed.ic.x100Yi-Swz.png";

            Food.Add(new Food { FoodName="Apple",Calories=50,Image=image});
            Food.Add(new Food { FoodName = "Orange", Calories = 70, Image = image });
            Food.Add(new Food { FoodName = "Bread", Calories = 150, Image = image });

            FoodGroups.Add(new Grouping<string, Food>("Baking", new[] { Food[2] }));
            FoodGroups.Add(new Grouping<string, Food>("Fruit", Food.Take(2)));

            RefreshCommand = new AsyncCommand(Refresh);
        }

        async Task Refresh()
        {
            IsBusy = true;
            await Task.Delay(2000);
            IsBusy = false;
        }
    }
}