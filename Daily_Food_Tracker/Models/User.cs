using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_Food_Tracker.Models
{
    class User
    {
        //[PrimaryKey, AutoIncrement]
        private int ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string DailyGoal { get; set; }
    }
}
