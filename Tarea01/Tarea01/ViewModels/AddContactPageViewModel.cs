using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Tarea01.Models;
using Xamarin.Forms;

namespace Tarea01.ViewModels
{
    class AddContactPageViewModel
    {
        public Contacts Contacts { get; set; } = new Contacts();
        public ICommand GetInfoCommand { get; set; }

        public AddContactPageViewModel()
        {
            var x = Contacts.Name;
            var y = Contacts.Number;

           
        }
    }
}
