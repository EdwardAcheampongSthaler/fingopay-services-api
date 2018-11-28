using System;
using System.Collections.Generic;

namespace STH.FingopayApp.ClientApi.Domain.Domain
{
    /// <summary>
    /// A user attached to an account
    /// </summary>
    public class UserViewModel : BaseDomain
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public int MobileNumber { get; set; }
        public string Description { get; set; }
        public bool IsAdminRole { get; set; }
        public ICollection<string> Roles { get; set; }  //map from semicolumn delimited from Entity
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public Guid AccountId { get; set; }
        public virtual AccountViewModel Account { get; set; }

       // public virtual ICollection<UserSecurityQuestionViewModel> UserSecurityQuestions { get; set; }
       // public virtual ICollection<SecurityQuestionViewModel> SecurityQuestions { get; set; }
    }
}
