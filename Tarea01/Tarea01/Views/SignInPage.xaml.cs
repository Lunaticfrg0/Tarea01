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
    public partial class SignInPage : ContentPage
    {
        public SignInPage()
        {
            InitializeComponent();
            BindingContext = new SignInPageViewModel();
        }

    }
}