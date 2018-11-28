using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace STH.FingopayApp.ClientApi.Entity.Entity
{
    public class Preference : BaseEntity
    {

        [Required]
        [StringLength(255)]
        public string Description { get; set; }


    }
}
