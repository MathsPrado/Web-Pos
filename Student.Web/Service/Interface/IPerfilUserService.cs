using Student.Web.Model;
using Student.Web.Pages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student.Web.Service
{
    public interface IPerfilUserService
    {
        IEnumerable<PerfilUser> GetAll();
        Task<PerfilUser> FindById(int id);
        PerfilUser Create(PerfilUser value);
        PerfilUser Update(PerfilUser value);
        PerfilUser Delete(int id);
    }
}
