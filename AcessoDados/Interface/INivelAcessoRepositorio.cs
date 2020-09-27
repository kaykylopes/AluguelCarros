using AluguelCarros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Interface
{
    public interface INivelAcessoRepositorio: IRepositorioGenerico<NiveisAcesso>
    {
        Task<bool> NivelAcessoExiste(string nivelAcesso);
    }
}
