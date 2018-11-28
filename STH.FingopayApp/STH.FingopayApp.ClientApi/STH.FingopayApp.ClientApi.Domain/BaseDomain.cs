using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace STH.FingopayApp.ClientApi.Domain
{
    public class BaseDomain
    {
        public Guid Id { get; set; }
    }
}
