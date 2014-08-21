using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BigBang.Api.Models;
using BrockAllen.MembershipReboot;

namespace BigBang.Api.Controllers
{
    public class UserAccountController : ApiController
    {
        UserAccountService _userAccountService;
        AuthenticationService _authService;

        public UserAccountController(AuthenticationService authService)
        {
            _userAccountService = authService.UserAccountService;
            _authService = authService;
        }

        [HttpPost]
        public IHttpActionResult Login([FromBody] LoginInputModel model)
        {
            UserAccount account;
            if (_userAccountService.AuthenticateWithUsernameOrEmail(model.Username, model.Password, out account))
            {
                _authService.SignIn(account, model.RememberMe);                
            }
            else
            {
                return Unauthorized();
            }

            return Ok();
        }
    }
}
