using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;
using SQLite;
using Daily_Food_Tracker.Models;
using System;

namespace Daily_Food_Tracker.Services
{
    public static class FoodService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null) return;
            //
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "FoodDataBase.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<Food>();
        }

        public static async Task AddFood(string foodid, string foodname, string alcohol, string carbohydrates, string calcium, 
            string cholesterol, string calories, string kilojule, string fat, string glucose, string iron, string lactose, 
            string magnesium, string potassium, string selenium, string sodium, string starch, string sugars, string water, string zinc)
        {
            //var image = "https://grandseasonscoquitlam.com/img/placeholders/xcomfort_food_placeholder.png,qv=1.pagespeed.ic.x100Yi-Swz.png";
            await Init();
            var food = new Food
            {
                FoodID = foodid,
                FoodName = foodname,
                Alcohol = alcohol,
                Carbohydrates = carbohydrates,
                Calcium = calcium,
                Cholesterol = cholesterol,
                Kilojule = kilojule,
                Fat = fat,
                Glucose = glucose,
                Iron = iron,
                Lactose = lactose,
                Magnesium = magnesium,
                Potassium = potassium,
                Selenium = selenium,
                Sodium = sodium,
                Starch = starch,
                Sugars = sugars,
                Water = water,
                Zinc = zinc,
            };
            var id = await db.InsertAsync(food);
        }
        public static async Task RemoveFood(int id)
        {
            await Init();

            await db.DeleteAsync<Food>(id);
        }
        public static async Task<IEnumerable<Food>> GetFood()
        {
            await Init();

            var food = await db.Table<Food>().ToListAsync();
            return food;
        }
    }
}
