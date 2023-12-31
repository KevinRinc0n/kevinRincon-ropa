using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;
using Microsoft.EntityFrameworkCore;

namespace Aplicacion.Repository;

public class VentaRepository : GenericRepository<Venta>, IVenta
{
    private readonly ApiDbContext _context;

    public VentaRepository(ApiDbContext context) : base(context)
    {
        _context = context;
    }

   
}