using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankDKI.Models
{
    public class UserModel
    {
        public decimal Id { get; set; }
        public string UserName { get;set; }
        public string Password { get; set; }
    }
}