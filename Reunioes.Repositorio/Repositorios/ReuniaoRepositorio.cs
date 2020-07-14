using System;
using System.Linq;
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

        public Reuniao ObterPorDataHora(DateTime datainicio, DateTime dataFim, int id)
        {


            return ReunioesContexto.Reunioes.FirstOrDefault(
                r => datainicio > r.DataHoraInicio
                && dataFim < r.DataHoraFim
                ||
                datainicio > r.DataHoraInicio
                && datainicio < r.DataHoraFim
                ||
                dataFim > r.DataHoraInicio
                && dataFim < r.DataHoraFim
                );

            
        }
    }
}
