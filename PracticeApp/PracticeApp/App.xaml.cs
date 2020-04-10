using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PracticeApp.View;
using PracticeApp.WebCalls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PracticeApp
{
    public partial class App : Application
    {
        public static RestManager RestAPIManager { get; set; }
        public App()
        {
            InitializeComponent();

            RestAPIManager = new RestManager(new RestService());
            MainPage = new REST();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
