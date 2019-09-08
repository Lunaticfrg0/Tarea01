using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea01.Models
{
    public class Contacts
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public Contacts() { }
        public Contacts(string Name, string Number)
        {
            this.Name = Name;
            this.Number = Number;
        }
    }
}
