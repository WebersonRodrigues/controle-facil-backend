using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Damain.Models;

namespace ControleFacil.Api.Damain.Repository.Interfaces
{
    public interface INaturezaDeLancamentoRepository : IRepository<NaturezaDeLancamento, long>
    {
        Task<IEnumerable<NaturezaDeLancamento>> ObterPeloIdUsuario(long idUsuario);
    }
}