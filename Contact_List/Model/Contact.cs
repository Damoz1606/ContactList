using System;
using System.Collections.Generic;
using System.Text;

namespace Contact_List.Model
{
    public class Contact
    {
        public string _name { get; set; }
        public string _last_name { get; set; }
        public string _phone_number { get; set; }
        public string _gender { get; set; }

        public Contact()
        {
            this._name = string.Empty;
            this._last_name = string.Empty;
            this._phone_number = string.Empty;
            this._gender = string.Empty;
        }

        public Contact(string _name, string _last_name, string _phone_number, string _gender)
        {
            this._name = _name;
            this._last_name = _last_name;
            this._phone_number = _phone_number;
            this._gender = _gender;
        }
    }
}
