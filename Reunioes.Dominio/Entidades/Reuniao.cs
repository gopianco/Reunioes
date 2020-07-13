using System;
namespace Reunioes.Dominio.Entidades
{
    public class Reuniao : Entidade
    {
        public int ReuniaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public string Titulo { get; set; }

        public int SalaId { get; set; }
        public virtual Sala Sala { get; set; }


        public Reuniao()
        {
        }

        public override void Validate()
        {
            LimparValidacao();

            if (DataHoraFim < DataHoraInicio)
            {
                AdicionarMensagem("Data final não pode ser maior que a data do incio");
            }
            if (DataHoraInicio == DataHoraFim)
            {
                AdicionarMensagem("A reunião é muito curta");
            }

           
        }
    }
}
