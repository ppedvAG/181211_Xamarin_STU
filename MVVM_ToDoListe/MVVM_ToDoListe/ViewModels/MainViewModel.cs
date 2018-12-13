using MVVM_ToDoListe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MVVM_ToDoListe.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        // ctor + TAB + TAB
        public MainViewModel()
        {
            // Controllfreak-Antipattern
            service = new ToDoItemService();
            GetToDoItemCommand = new Command(GetToDoItem);
        }

        private void GetToDoItem(object obj)
        {
            Items = service.GetToDoItems();
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        private ToDoItemService service;

        public event PropertyChangedEventHandler PropertyChanged;

        //prop + TAB + TAB
        public Command GetToDoItemCommand { get; set; }
        public List<ToDoItem> Items { get; set; }
    }
}
