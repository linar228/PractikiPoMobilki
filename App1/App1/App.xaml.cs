using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.SQLITE;
using System.IO;

namespace App1
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "Project.db";
        internal static SQLProject db;
        internal static SQLProject Db
        {
            get
            {
                if (db == null)
                {
                    db = new SQLProject(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return db;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
