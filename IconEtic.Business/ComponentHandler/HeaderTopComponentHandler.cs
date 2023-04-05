using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Business.Helpers;
using IconEtic.Business.Services;
using Microsoft.AspNetCore.Http;

namespace IconEtic.Business.ComponentHandler
{
    public class HeaderTopComponentHandler : IHeaderTopComponentHandler
    {
        private readonly ICookieHelper _cookieHelper;
        private IUserService _userService;

        public HeaderTopComponentHandler(ICookieHelper cookieHelper, IUserService userService)
        {
            _cookieHelper = cookieHelper;
            _userService = userService;
        }

        public User GetUserData(string guidKey, HttpRequest request)
        {
            var cookie = _cookieHelper.Read(CookieTypes.User, request);
            if (cookie == null)
            {
                return null;
            }
            var user = _userService.GetUserDataWithGuidkey(cookie);
            return user;

        }

       
    }

    public interface IHeaderTopComponentHandler
    {
        User GetUserData(string guidKey, HttpRequest request);
       
    }
}
