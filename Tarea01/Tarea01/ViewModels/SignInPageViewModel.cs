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
    class SignInPageViewModel : INotifyPropertyChanged
    {

        public NewUser NewUser { get; set; } = new NewUser();
        public ICommand RegistroCommand { get; set; }
        public string Messeger { get; set; }

        public SignInPageViewModel()
        {
            RegistroCommand = new Command(async() =>
            {
                if (String.IsNullOrEmpty(NewUser.Username) || String.IsNullOrEmpty(NewUser.Email) ||
                 String.IsNullOrEmpty(NewUser.Password) || String.IsNullOrEmpty(NewUser.PasswordConfirmed))
                {
                    Messeger = "Empty field!";
                }
                else if (NewUser.PasswordConfirmed != NewUser.Password)
                {
                    Messeger = "There is no match in the passwords provided!";
                }
                else
                {
                    App.Current.MainPage = new NavigationPage(new LoggedUserPage());

                }

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
