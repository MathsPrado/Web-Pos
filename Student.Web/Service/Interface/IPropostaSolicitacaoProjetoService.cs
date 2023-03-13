using Student.Web.Model;
using Student.Web.Pages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student.Web.Service
{
    public interface IPropostaSolicitacaoProjeto
    {
        IEnumerable<PropostaSolicitacaoProjeto> GetAll();
        Task<PropostaSolicitacaoProjeto> FindById(int id);
        PropostaSolicitacaoProjeto Create(PropostaSolicitacaoProjeto value);
        PropostaSolicitacaoProjeto Update(PropostaSolicitacaoProjeto value);
        PropostaSolicitacaoProjeto Delete(int id);
    }
}
