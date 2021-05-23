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

//namespace Daily_Food_Tracker.Services
//{
//    class FoodService
//    {
//        static SQLiteAsyncConnection db;
//        public static async Task Init()
//        {
//            if (db != null)
//            return;
        
//            var databasepath = Path.Combine(FileSystem.AppDataDirectory, "MyDatabase");

//            var db = new SQLiteAsyncConnection(databasepath);

//            await db.CreateTableAsync<Food>();
//        }

//        public static async Task AddFood(string FoodID, string FoodName)
//        {
//            await Init();
//            new food = new Food
//            {
//                FoodID = foodid,
//                FoodName = foodname,
//                Alcohol = alcohol,              
//            }
//            var id = await db.InsertAsync(food);
//        }
//        public static async Task RemoveFood(string FoodID, string FoodName)
//        {
//            await Init();
//        }
//        public static async Task GetFood(string FoodID, string FoodName)
//        {
//            await Init();
//        }
//    }
//}
