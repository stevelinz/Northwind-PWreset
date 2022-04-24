using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Models
{
    public class ResetPassword 
    {
        public int ResetPasswordId { get; set; }
        public string ResetPWemail { get; set; }
        public string ResetCode { get; set; }
    }
} 
  