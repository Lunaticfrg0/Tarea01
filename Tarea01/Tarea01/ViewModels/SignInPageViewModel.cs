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

        public NewUser newUser { get; set; } = new NewUser();
        public ICommand RegistroCommand { get; set; }
        public string Messeger { get; set; }

        public SignInPageViewModel()
        {
            RegistroCommand = new Command(async() =>
            {
                if (String.IsNullOrEmpty(newUser.Username) || String.IsNullOrEmpty(newUser.Email) ||
                 String.IsNullOrEmpty(newUser.Password) || String.IsNullOrEmpty(newUser.PasswordConfirmed))
                {
                    Messeger = "Empty field!";
                }
                else if (newUser.PasswordConfirmed != newUser.Password)
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
