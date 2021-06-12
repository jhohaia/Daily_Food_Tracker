using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using System.IO;

namespace Daily_Food_Tracker.Droid
{
    [Activity(Label = "Daily_Food_Tracker", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            // db
            string dbName = "foodsql.db";
            string dbPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), dbName);
            // Check if your DB has already been extracted.
            if (!File.Exists(dbPath))
            {
                using (BinaryReader br = new BinaryReader(Android.App.Application.Context.Assets.Open(dbName)))
                {
                    using (BinaryWriter bw = new BinaryWriter(new FileStream(dbPath, FileMode.Create)))
                    {
                        byte[] buffer = new byte[2048];
                        int len = 0;
                        while ((len = br.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            bw.Write(buffer, 0, len);
                        }
                    }
                }
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        //CopyDatabase
        //private void copydatabase(string databasename)
        //{
        //    var dbpath = system.io.path.combine(system.environment.getfolderpath(system.environment.specialfolder.personal), databasename);

        //    if (!system.io.file.exists(dbpath))
        //    {
        //        var dbassetstream = assets.open(databasename);
        //        var dbfilestream = new system.io.filestream(dbpath, system.io.filemode.openorcreate);
        //        var buffer = new byte[1024];

        //        int b = buffer.length;
        //        int length;

        //        while ((length = dbassetstream.read(buffer, 0, b)) > 0)
        //        {
        //            dbfilestream.write(buffer, 0, length);
        //        }

        //        dbfilestream.flush();
        //        dbfilestream.close();
        //        dbassetstream.close();
        //    }

        //}
    }
}