using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea01
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OpenBotton(object obj, EventArgs clicked)
        {
            string nombre = entNombre.Text;

            if (string.IsNullOrEmpty(entNombre.Text) || string.IsNullOrEmpty(entPassword.Text))
            {
                await DisplayAlert("Campo vacio!", " El campo de nombre y/o contraseña estan vacios ", "OK");

            }
            else
            {
                await DisplayAlert("Bienvenido", $"Hola, te damos la bienvenida {nombre}!", "OK");
            }
        }
    }
}
