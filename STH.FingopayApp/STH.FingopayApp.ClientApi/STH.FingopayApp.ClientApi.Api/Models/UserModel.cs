using System;
using System.Collections;
using System.Collections.Generic;

namespace STH.FingopayApp.ClientApi.Api.Models
{

    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public DateTime Birthdate { get; set; }
        public IEnumerable<Preference> Preferences { get; set; }
        public bool AgreeTermsAndConditions { get; set; }
        public string[] Roles { get; set; }
    }

    public class Preference
    {
        public string Description { get; set; }
        public bool Enabled { get; set; }
    }
}