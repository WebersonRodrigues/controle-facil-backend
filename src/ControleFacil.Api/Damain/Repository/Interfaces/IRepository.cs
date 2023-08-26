using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Damain.Repository.Interfaces
{
    public interface IRepository<T, I> where T : class
    {
        Task<IEnumerable<T>> Obter();
        Task<T?> Obter(I id);

        Task<T> Adicionar(T entidade);

        Task<T> Atualizar(T entidade);
        Task Deletar(T entidade);
    }
}