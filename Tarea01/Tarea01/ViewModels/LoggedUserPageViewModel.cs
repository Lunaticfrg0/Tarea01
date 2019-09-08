using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Tarea01.Models;
using Tarea01.Views;
using Xamarin.Forms;

namespace Tarea01.ViewModels
{
    class LoggedUserPageViewModel : INotifyPropertyChanged
    {
        public Contacts Contacts { get; set; } = new Contacts();

        public ObservableCollection<Contacts> Contact { get; set; } = new ObservableCollection<Contacts>();

        public ICommand AddCommand { get; set; }
        public ICommand ContactsOptions { get; set; }
        public ICommand DeleteOption { get; set; }
        public ICommand EditContact { get; set; }

        public LoggedUserPageViewModel()
            
        {
            MessagingCenter.Subscribe<AddContactPageViewModel, Contacts>(this, "ID", ((sender, Contacts) =>
            {
                Contact.Add(Contacts);
            }));

            //Contact.Add(new Contacts() { Name = "Emilio", Number = "8096239275" });

            AddCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
                

            });

            ContactsOptions = new Command<Contacts>(async (Contacts) =>
            {
                string option = await App.Current.MainPage.DisplayActionSheet(null, "Cancel",null, "Deal " + Contacts.Number, "Edit");

                if (option == "Edit")
                {
                    
                    await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
                    Contact.Remove(Contacts);

                }
                else
                {
                    Device.OpenUri(new Uri(String.Format("Phone:{0}", Contacts.Number)));
                }
            });

            DeleteOption = new Command<Contacts>(async (Contacts) =>
            {
                Contact.Remove(Contacts);
            });

           
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
