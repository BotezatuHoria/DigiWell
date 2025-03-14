﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenInfoEducatieAppplication
{
    class UserRegister
    {
        private string _fName, _lName, _email, _password;
        private int _id;

        public UserRegister()
        {

        }

        public UserRegister(int _id)
        {
            this._id = _id;

        }

        public UserRegister(string _email, string _fname, string _lname, string _password)
        {
            this._fName = _fname;
            this._lName = _lname;
            this._email = _email;
            this._password = _password;
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string firstName
        {
            get { return _fName; }
            set { _fName = value; }
        }

        public string lastName
        {
            get { return _lName; }
            set { _lName = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}
