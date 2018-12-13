using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSeite2NavigationPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Seite2());
        }

        private void ButtonSeite2Modal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());
        }
    }
}
