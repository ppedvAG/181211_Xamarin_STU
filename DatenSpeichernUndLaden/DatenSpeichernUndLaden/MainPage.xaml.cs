using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;


namespace DatenSpeichernUndLaden
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string path = FileSystem.AppDataDirectory + "\\db.sqlite";
            con = new SQLiteConnection(path);

            // Wichtig: erstellt die Tabelle nur, wenn sie nicht bereits schon existiert
            con.CreateTable<Person>(); 
        }
        private SQLiteConnection con;


        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ISaveAndLoad>();
            service.Save("demo.txt", entryText.Text);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<ISaveAndLoad>();
            DisplayAlert("Textfile", service.Load("demo.txt"), "OK");
        }

        private void ButtonDBEinfügen_Clicked(object sender, EventArgs e)
        {
            Person p = new Person();
            p.Vorname = entryVorname.Text;
            p.Nachname = entryNachname.Text;
            p.Alter = 100;
            p.Kontostand = 100000;

            con.Insert(p);
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>(); // Entspricht SELECT * FROM Person

            // LINQ
            // con.Query<Person>().Where( ....... )

            // Variante 1)
            // listViewPersonen.IsRefreshing = false;

            // Variante 2)
            listViewPersonen.EndRefresh(); 
        }
    }
}
