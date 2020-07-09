using System;
using Reunioes.Dominio.Contratos;
using Reunioes.Dominio.Entidades;
using Reunioes.Repositorio.Contexto;

namespace Reunioes.Repositorio.Repositorios
{
    public class ReuniaoRepositorio : BaseRepositorio<Reuniao>, IReuniaoRepositorio
    {
        public ReuniaoRepositorio(ReunioesContexto reunioesContexto) : base(reunioesContexto)
        {
        }
    }
}
