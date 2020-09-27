using AluguelCarros.AcessoDados.Interface;
using AluguelCarros.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Repositorio
{
    public class AluguelRepositorio : RepositorioGenerico<Aluguel>, IAluguelRepositorio
    {
        private readonly Contexto _contexto;

        public AluguelRepositorio(Contexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

       

        public async Task<bool> VeificarReserva(string usuarioId, int carroId, string dataInicio, string dataFim)
        {
            return await _contexto.Alugueis.AnyAsync(a => a.UsuarioId == usuarioId && a.CarroId == carroId && a.Inicio == dataInicio && a.Fim == dataFim);
        }
    }
}
