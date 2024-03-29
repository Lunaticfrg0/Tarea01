﻿using System;
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
    public partial class LoggedUserPage : ContentPage
    {
        public LoggedUserPage()
        {
            InitializeComponent();
            BindingContext = new LoggedUserPageViewModel();
        }
        async private void SendToAddView(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddContactPage());
        }


        
    }
}