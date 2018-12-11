using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // "MessageBox" in Xamarin.Forms

            // Variante 1:
            DisplayAlert("Eine Nachricht nur für dich", "Hallo Welt", "OK");

        }
    }
}
