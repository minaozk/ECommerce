using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Etic.Entities;

namespace IconEtic.Business.Services
{
    public interface ILoginService
    {
        User Login(string username, string password);
    }
}
