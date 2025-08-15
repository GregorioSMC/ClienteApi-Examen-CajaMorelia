using ClienteApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApi.Aplication.Services
{
    public interface IClienteService
    {
        Task<IEnumerable<Cliente>> ObtenerClientes();
        Task<Cliente?> ObtenerClientePorId(int id);
        Task CrearCliente(Cliente cliente);
        Task ActualizarCliente(Cliente cliente);
        Task EliminarCliente(int id);
    }
}
