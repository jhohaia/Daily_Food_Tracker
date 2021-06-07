using Daily_Food_Tracker.Models;
using Daily_Food_Tracker.Services;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Daily_Food_Tracker.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    { 
    public ObservableRangeCollection<Food> Food { get; set; }
    public ObservableRangeCollection<Grouping<string, Food>> FoodGroups { get; set; }
    public AsyncCommand RefreshCommand { get; }
    public AsyncCommand AddCommand { get; }
    public AsyncCommand<Food> RemoveCommand { get; }
    
        public HomePageViewModel()
        {
            Title = "Home";
            Food = new ObservableRangeCollection<Food>();
            RefreshCommand = new AsyncCommand(Refresh);    
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