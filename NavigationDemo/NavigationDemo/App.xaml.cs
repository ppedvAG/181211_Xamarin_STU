using NavigationDemo.MD;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NavigationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            // NavigationPage kapselt eine ContentPage -> Navigationsleiste
            // MainPage = new NavigationPage(new MainPage());
            // MainPage = new TabbedPageDemo();

            // TabPage erstellen, Klasse durch CarouselPage austauschen in xaml und xaml.cs, da leider kein Template existiert
            // MainPage = new CarouselPageDemo();
            MainPage = new MasterDetailPageDemo();

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
