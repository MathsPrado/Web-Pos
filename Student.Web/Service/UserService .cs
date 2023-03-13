using System;
using Student.Web.Model;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Student.Web.Service.Interface;

namespace Student.Web.Service
{
    public class UserService : IUser
    {
        public async Task<bool> LoginAsync(User user)
        {
            var returnedUser = false;

            if (user.email == "matheus@hotmail.com" && user.password == "123456")
            {
                returnedUser = true;
            }

            return await Task.FromResult(returnedUser);

        }
    }
}