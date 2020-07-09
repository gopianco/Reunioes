using System;
using Reunioes.Dominio.Contratos;
using Reunioes.Dominio.Entidades;
using Reunioes.Repositorio.Contexto;

namespace Reunioes.Repositorio.Repositorios
{
    public class SalaRepositorio : BaseRepositorio<Sala>, ISalaRepositorio
    {
        public SalaRepositorio(ReunioesContexto reunioesContexto) : base(reunioesContexto)
        {
        }
    }
}
