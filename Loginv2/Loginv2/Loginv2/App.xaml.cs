using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Loginv2.Views;
using Loginv2.Models;

namespace Loginv2

{
    public partial class App : Application
    {
        public static string DbPath;
        public static string DbNome;
        RegisterPage rg;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
            rg = new RegisterPage();
            rg.inserirTimes();
            
        }

        public App(string dbPath, string dbNome)
        {
            InitializeComponent();

            App.DbPath = dbPath;
            App.DbNome = dbNome;
            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
