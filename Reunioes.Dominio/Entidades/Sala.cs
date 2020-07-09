using System;
using System.Collections.Generic;

namespace Reunioes.Dominio.Entidades
{
    public class Sala : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual List<Reuniao> Reunioes { get; set; }

        public Sala()
        {
        }

        public override void Validate()
        {
            LimparValidacao();

            if (Id == 0)
            {
                AdicionarMensagem(" O ID da sala não pode ser nulo");
            }

            if (string.IsNullOrEmpty(Nome))
            {
                AdicionarMensagem("O nome da sala não pode estar vazio");
            }

        }
    }
}
