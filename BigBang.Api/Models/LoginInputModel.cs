using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigBang.Api.Models
{
    public class LoginInputModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }

    public class RegisterInputModel
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}