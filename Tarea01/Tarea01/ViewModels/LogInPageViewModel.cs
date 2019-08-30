using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Tarea01.Models;
using System.Threading.Tasks;
using Tarea01.Views;
using System.ComponentModel;

namespace Tarea01.ViewModels
{
    class LogInPageViewModel : INotifyPropertyChanged
    {
        public User User { get; set; } = new User();
        public ICommand LogInCommand { get; set; }

        public string Messege { get; set; }
        public LogInPageViewModel()
        {
            LogInCommand = new Command(async () =>
            {

                if (String.IsNullOrEmpty(User.Username) || String.IsNullOrEmpty(User.Password))
                {
                    Messege = "Empty Field";
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
