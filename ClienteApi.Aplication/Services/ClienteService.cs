using ClienteApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteApi.Infrastructure.Repositories;

namespace ClienteApi.Aplication.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IGenericRepository<Cliente> _repo;

        public ClienteService(IGenericRepository<Cliente> repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Cliente>> ObtenerClientes() => await _repo.GetAllAsync();
        public async Task<Cliente?> ObtenerClientePorId(int id) => await _repo.GetByIdAsync(id);
        public async Task CrearCliente(Cliente cliente) => await _repo.AddAsync(cliente);
        public async Task ActualizarCliente(Cliente cliente) => await _repo.UpdateAsync(cliente);
        public async Task EliminarCliente(int id)
        {
            var cliente = await _repo.GetByIdAsync(id);
            if (cliente != null) await _repo.DeleteAsync(cliente);
        }
    }
}
