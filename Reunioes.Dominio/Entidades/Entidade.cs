using System;
using System.Collections.Generic;
using System.Linq;

namespace Reunioes.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        protected void LimparValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string msg)
        {
            mensagemValidacao.Add(msg);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }

        public Entidade()
        {
        }
    }
}
