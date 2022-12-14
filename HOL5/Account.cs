using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _HOL4.Models
{
    public class Account
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int AccountNumber { get; set; }
        [Remote("CheckAccountNumber", "Home")]
        [Range(1, long.MaxValue, ErrorMessage = "Account number cannot be  negative or zero")]




        public string Name { get; set; }
        [StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "Minimum  length must be 2")]

        [Required(ErrorMessage = "Name must be specified")]




        public double CurrentBalance { get; set; }
        [Range(500, long.MaxValue, ErrorMessage = "Minimum balance must be  500")]
    }



    

    
}