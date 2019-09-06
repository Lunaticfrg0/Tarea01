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
    public partial class AddContactPage : ContentPage
    {
        public AddContactPage()
        {
            InitializeComponent();
            BindingContext = new AddContactPageViewModel();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new LoggedUserPage());

        }
    }
}