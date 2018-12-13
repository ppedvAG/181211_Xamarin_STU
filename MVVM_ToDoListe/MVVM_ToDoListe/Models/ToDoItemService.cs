using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace MVVM_ToDoListe.Models
{
    class ToDoItemService
    {
        public List<ToDoItem> GetToDoItems()
        {
            // 1) JSON herunterladen
            // 2) Deserialisieren
            // 3) Liste zurückgeben
            string json;
            using (HttpClient client = new HttpClient())
            {
                json = client.GetStringAsync("https://jsonplaceholder.typicode.com/todos").Result;
            }

            return JsonConvert.DeserializeObject<List<ToDoItem>>(json);
        }
    }
}
