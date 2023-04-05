using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Helpers;
using IconEtic.Business.Models;
using IconEtic.Business.Services;
using Microsoft.AspNetCore.Http;

namespace IconEtic.Business.ControllerHandler
{
    public class AuthenticationControllerHandler : IAuthenticationControllerHandler
    {
        private readonly ILoginService _loginService;
        private readonly ICookieHelper _cookieHelper;
        private readonly IUserService _userService;

        public AuthenticationControllerHandler(ILoginService loginService, ICookieHelper cookieHelper, IUserService userService)
        {
            _loginService = loginService;
            _cookieHelper = cookieHelper;
            _userService = userService;
        }

        public User Login(string email, string password)
        {
            var result = _loginService.Login(email, password);
            if (result == null)
            {
                return null;
            }

            return result;


        }


        public bool UserLogin(string email, string password, HttpResponse httpResponse)
        {
            password = StringHelper.ToMd5(password).ToLower();
            var loginResult = Login(email, password);
            if (loginResult is not null)
            {
                var key = _userService.ChangeGuidKey(loginResult);
                _cookieHelper.Create(CookieTypes.User, key,DateTime.Now.AddYears(1), httpResponse);
                return true;

            }
            else
            {
                return false;
            }
        }

        public bool Exit(HttpRequest httpRequest)
        {
            try
            {
                var cookie = _cookieHelper.Read(CookieTypes.User, httpRequest);
                if (cookie == null)
                {
                    return false;
                }
                _userService.ResetUserGuidKey(cookie);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }

    public interface IAuthenticationControllerHandler
    {
       public User Login(string email, string password);
        public bool UserLogin(string email, string password, HttpResponse httpResponse);
        public bool Exit(HttpRequest HttpRequest);
    }
}
