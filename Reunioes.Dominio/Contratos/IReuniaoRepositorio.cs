using System;
using Reunioes.Dominio.Entidades;

namespace Reunioes.Dominio.Contratos
{
    public interface IReuniaoRepositorio : IBaseRepositorio<Reuniao>
    {
        Reuniao ObterPorDataHora(DateTime datainicio, DateTime dataFim, int id);
    }
}
