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
        [Route("api/UserAccount/Login")]
        public IHttpActionResult Login([FromBody] LoginInputModel model)
        {
            UserAccount account;
            if (_userAccountService.AuthenticateWithUsernameOrEmail(model.UsernameOrEmail, model.Password, out account))
            {
                try
                {
                    _authService.SignIn(account, model.RememberMe);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            else
            {
                return Unauthorized();
            }

            return Ok();
        }

        [HttpPost]
        [Route("api/UserAccount/Register")]
        public IHttpActionResult Register([FromBody] RegisterInputModel model)
        {
            try
            {
                var account = _userAccountService.CreateAccount(username: model.Username, password: model.Password,
                    email: model.Email, dateCreated: DateTime.Now);
                return Ok(account.Username);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
