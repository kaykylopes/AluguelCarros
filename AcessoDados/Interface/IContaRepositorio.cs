using AluguelCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Interface
{
    public interface IContaRepositorio : IRepositorioGenerico<Conta>
    {
        new Task<IEnumerable<Conta>> PegarTodos();
        int PegarSaldoPeloId(string id);
        Task<Conta> PegarSaldoPeloUsuarioId(string id);
    }
}
