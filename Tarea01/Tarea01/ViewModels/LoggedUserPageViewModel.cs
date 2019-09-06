using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tarea01.Models;
using Tarea01.Views;
using Xamarin.Forms;

namespace Tarea01.ViewModels
{
    class LoggedUserPageViewModel
    {
        public Contacts Contacts { get; set; } = new Contacts();

        public List<Contacts> Contact { get; set; } = new List<Contacts>();

        public ICommand AddCommand { get; set; }
        public ICommand ContactsOptions { get; set; }

        public LoggedUserPageViewModel()
            
        {
            MessagingCenter.Subscribe<AddContactPage, Contacts>(this, "Hi", async (sender, Contacts) =>
            {
                Contact.Add(Contacts);
            });

            Contact.Add(new Contacts() { Name = "Emilio" , Number= "8096239275"}) ;
            AddCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
                

            });

            ContactsOptions = new Command<Contacts>(async (Contacts) =>
            {
                string option = await App.Current.MainPage.DisplayActionSheet(null, "Cancel", null, "Call " + Contacts.Number, "Edit");

                if (option == "Edit")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
                }
                else
                {
                    Device.OpenUri(new Uri(String.Format("tel:{0}", Contacts.Number)));
                }
            });



        }

    }
}
