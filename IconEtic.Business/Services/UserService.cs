using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;
using IconEtic.Data.Abstract;
using IconEtic.Data.Concrete;

namespace IconEtic.Business.Services
{
   public class UserService : IUserService
    {
        private IUserDal _userDal;


        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public string ChangeGuidKey(User user)
        {
            var key = Guid.NewGuid().ToString();
            user.LoginGuidKey = key;
            _userDal.Update(user);
            return key;
        }

        public User GetUserDataWithGuidkey(string guid)
        {
            return _userDal.Get(x => x.LoginGuidKey == guid);
        }

        public void ResetUserGuidKey(string guid)
        {
            var user = GetUserDataWithGuidkey(guid);
            user.LoginGuidKey = null;
            _userDal.Update(user);
        }
    }

    public interface IUserService
    {
        string ChangeGuidKey(User user);
        User GetUserDataWithGuidkey(string guid);
        void ResetUserGuidKey(string guid);
    }
}
