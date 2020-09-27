using AluguelCarros.AcessoDados.Interface;
using AluguelCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Repositorio
{
    public class CarroRepositorio : RepositorioGenerico<Carro>, ICarroRepositorio
    {
        public CarroRepositorio(Contexto contexto) : base(contexto)
        {
        }
    }
}
