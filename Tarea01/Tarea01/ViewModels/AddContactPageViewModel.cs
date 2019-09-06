using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea01.Models;
using Tarea01.Views;
using Xamarin.Forms;

namespace Tarea01.ViewModels
{
    class AddContactPageViewModel : INotifyPropertyChanged
    {
        public Contacts Contacts { get; set; } = new Contacts();
        public ICommand GetInfoCommand { get; set; }

        public AddContactPageViewModel()
        {
            GetInfoCommand = new Command(async () =>
           {
               MessagingCenter.Send<AddContactPageViewModel, Contacts>(this, "ID", Contacts);
               await App.Current.MainPage.Navigation.PopAsync();
           });
            

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
