using Dominio.Entities;

namespace Dominio.Interfaces;

public interface IOrden : IGenericRepository<Orden>
{
    Task<IEnumerable<Orden>> enProceso();
}