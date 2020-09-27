using AluguelCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Interface
{
   public interface IAluguelRepositorio : IRepositorioGenerico<Aluguel>
    {
        Task<bool> VeificarReserva(string usuarioId, int carroId, string dataInicio, string dataFim);
    }
}
