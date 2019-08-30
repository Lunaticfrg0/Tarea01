using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea01.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea01.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            BindingContext = new LogInPageViewModel();
           
        }
         void PassToSignIn(object obj , EventArgs eventArgs)
        {
            App.Current.MainPage = new NavigationPage(new SignInPage());
            App.Current.MainPage.Navigation.PopToRootAsync(true);
        }
    }
}