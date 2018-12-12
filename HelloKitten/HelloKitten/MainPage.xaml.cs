using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloKitten
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonSuchen_Clicked(object sender, EventArgs e)
        {
            imageBild.Source = ImageSource.FromUri(new Uri($"http://fillmurray.com/{entryBreite.Text}/{entryHöhe.Text}"));
        }
    }
}
