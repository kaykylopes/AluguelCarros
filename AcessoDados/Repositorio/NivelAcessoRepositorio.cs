using AluguelCarros.AcessoDados.Interface;
using AluguelCarros.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AluguelCarros.AcessoDados.Repositorio
{
    public class NivelAcessoRepositorio : RepositorioGenerico<NiveisAcesso>, INivelAcessoRepositorio
    {
        private readonly RoleManager<NiveisAcesso> _gerenciadorNivelAcesso;
        private readonly Contexto _contexto;

        public NivelAcessoRepositorio(Contexto contexto, RoleManager<NiveisAcesso> gerenciadorNivelAcesso) : base(contexto)
        {
            _gerenciadorNivelAcesso = gerenciadorNivelAcesso;
            _contexto = contexto;
        }

        public async Task<bool> NivelAcessoExiste(string nivelAcesso)
        {
            try
            {
                return await _gerenciadorNivelAcesso.RoleExistsAsync(nivelAcesso);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
