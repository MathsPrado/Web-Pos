using Student.Web.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Student.Web.Service
{
    public interface ISolicitacaoProjectServer
    {
        IEnumerable<SolicitacaoProjeto> GetAll();
        Task<SolicitacaoProjeto> FindById(int id);
        SolicitacaoProjeto Create(SolicitacaoProjeto value);
        SolicitacaoProjeto Update(SolicitacaoProjeto value);
        SolicitacaoProjeto Delete(int id);
    }
}
