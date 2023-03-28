using System;
using Student.Web.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student.Web.Service.Interface
{
    public interface IUser
    {
        public Task<bool> LoginAsync(User user);
    }
}