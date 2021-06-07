using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Daily_Food_Tracker.Models
{
    public class Food
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public string Alcohol { get; set; }
        public string Carbohydrates { get; set; }
        public string Calcium { get; set; }
        public string Cholesterol { get; set; }
        public string Calories { get; set; }
        public string Kilojule { get; set; }
        public string Fat { get; set; }
        public string Glucose { get; set; }
        public string Iron { get; set; }
        public string Lactose { get; set; }
        public string Magnesium { get; set; }
        public string Potassium { get; set; }
        public string Selenium { get; set; }
        public string Sodium { get; set; }
        public string Starch { get; set; }
        public string Sugars { get; set; }
        public string Water { get; set; }
        public string Zinc { get; set; }
    }
}
