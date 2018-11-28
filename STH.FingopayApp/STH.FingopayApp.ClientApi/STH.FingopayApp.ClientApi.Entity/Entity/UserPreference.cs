using System;
using System.ComponentModel.DataAnnotations;

namespace STH.FingopayApp.ClientApi.Entity.Entity
{
    public class UserPreference
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid PreferenceId { get; set; }
       
        [Required]
        public bool Enabled { get; set; }

        public virtual User User { get; set; }
        public virtual Preference Preference { get; set; }
    }
}