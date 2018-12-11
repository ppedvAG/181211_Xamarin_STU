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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // "MessageBox" in Xamarin.Forms

            // Variante 1: [OK]
            await DisplayAlert("Eine Nachricht nur für dich", "Hallo Welt", "OK");

            // Variante 2: [JA] [NEIN]
            bool erg = await DisplayAlert("Eine Nachricht nur für dich", "Hallo Welt", "Ja","Nein");

            // Variante 3: [X],[Y],[Z] -- viele
            string auswahl = await DisplayActionSheet("Wähle dein Obst", "Ok", "Abbrechen", "Apfel", "Birne", "Banane", "Ananas");
        }
    }
}
