using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Daily_Food_Tracker.Models
{
    public class Food
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string FoodID { get; set; }
        public string FoodName { get; set; }
        public double Alcohol { get; set; }
        public double Carbohydrates { get; set; }
        public double Calcium { get; set; }
        public double Cholesterol { get; set; }
        public double Calories { get; set; }
        public double Kilojule { get; set; }
        public double Fat { get; set; }
        public double Glucose { get; set; }
        public double Iron { get; set; }
        public double Lactose { get; set; }
        public double Magnesium { get; set; }
        public double Potassium { get; set; }
        public double Selenium { get; set; }
        public double Sodium { get; set; }
        public double Starch { get; set; }
        public double Sugars { get; set; }
        public double Water { get; set; }
        public double Zinc { get; set; }
        public string Image { get; set; }
    }
}
