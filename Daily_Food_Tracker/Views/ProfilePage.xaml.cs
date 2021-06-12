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
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }
        void saveButton_Clicked(object sender, System.EventArgs e)
        {
            ////string conString = "H:\YEAR3\PersonalInfo.db";
            //User user = new User()
            //{
            //    Name = NameInput.Text,
            //    Age = AgeInput.Text,
            //    Height = HeightInput.Text,
            //    Weight = WeightInput.Text,
            //    DailyGoal = DailyGoalInput.Text,
            //};

            //using (SQLite.SQLiteConnection conn = new SQLiteConnection(conString)) ;
        }
    }
}