using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiCA2MobileApp.Models;

namespace WebApiCA2MobileApp.Services
{
   internal  interface IUserService
    {

        // Get method
     Task<List<User>> RefreshUserDataAsync();
    }
}
