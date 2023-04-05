using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;

namespace IconEtic.Business.Services
{
    public class LoginService : ILoginService
    {
        private IUserDal _userDal;

        public LoginService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Login(string email , string password)
        {
           
            var output = _userDal.Get(x => x.Email == x.Email && x.Password == password);
            if (output == null)
            {
                return null;
            }
            else
            {
                return output;
            }
        }
    }
}
