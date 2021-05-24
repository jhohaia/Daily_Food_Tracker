//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.IO;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Xamarin.Essentials;
//using SQLite;
//using Daily_Food_Tracker.Models;
//using Daily_Food_Tracker.Services;

//namespace Daily_Food_Tracker.Services
//{
//    public class FoodService
//    {
//        static SQLiteAsyncConnection dba;
//        public static async Task Init()
//        {
//            if (dba != null) return;

//            var databasepath = Path.Combine(FileSystem.AppDataDirectory, "MyDatabase");

//            var db = new SQLiteAsyncConnection(databasepath);

//            await db.CreateTableAsync<Food>();
//        }

//        public static async Task AddFood(string FoodID, string FoodName)
//        {
//            var image = "https://grandseasonscoquitlam.com/img/placeholders/xcomfort_food_placeholder.png,qv=1.pagespeed.ic.x100Yi-Swz.png";
//            await Init();
//            var food = new Food
//            {
//                FoodID = FoodID,
//                FoodName = FoodName,
//                Image = image
//            };
//            var id = await dba.InsertAsync(food);
//        }
//        public static async Task RemoveFood(int id)
//        {
//            await Init();

//            await dba.DeleteAsync<Food>(id);
//        }
//        public static async Task<IEnumerable<Food>> GetFood()
//        {
//            await Init();

//            await dba.Table<Food>().ToListAsync();
//            return food;
//        }
//    }
//}
