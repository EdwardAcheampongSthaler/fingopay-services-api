using System;
using System.Collections.Generic;
using System.Text;

namespace STH.FingopayApp.ClientApi.Domain.Domain
{
    public class UserActivationCodeViewModel
    {
        public virtual Guid UserId { get; set; }
        public virtual Guid AccountId { get; set; }
        public string ActivationCode { get; set; }
        public DateTime ActivationCodeExpiryDateTime { get; set; }
        public bool ActivationCodeRedeemed { get; set; }
        public DateTime? ActivationCodeRedeemDateTime { get; set; }
    }

    public class SecurityQuestionViewModel:BaseDomain
    {
        public string QuestionText { get; set; }
    }

    public class UserSecurityQuestionViewModel
    {
        public Guid UserId { get; set; }
        public Guid QuestionId { get; set; }
        public string Answer { get; set; }
        public string Hint { get; set; }

    }



}
