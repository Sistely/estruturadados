using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static proj_Agenda.model.Contato;

namespace proj_Agenda.controller
{
    class Contatos
    {
        private List<model.Contato> meusContatos;

        public List<model.Contato> MeusContatos
        {
            get { return meusContatos; }
        }

        public Contatos()
        {
            meusContatos = new List<model.Contato>();
        }

        public void adicionar(model.Contato c)
        {
            this.meusContatos.Add(c);
        }

        public model.Contato pesquisar(model.Contato c)
        {
            model.Contato contatoAchado;
            contatoAchado = new model.Contato();
            foreach (model.Contato contato in this.meusContatos)
                if (contato.Equals(c))
                    contatoAchado = contato;
            return contatoAchado;
        }

        public bool alterar(model.Contato c)
        {
            int posicao;
            posicao = this.meusContatos.IndexOf(c);
            if (posicao > -1)
            {
                this.meusContatos.RemoveAt(posicao);
                this.meusContatos.Insert(posicao, c);
            }
            return (posicao > -1);
        }

        public bool remover(model.Contato c)
        {
            bool podeRemover;
            podeRemover = (this.meusContatos.IndexOf(c) > -1);
            if (podeRemover)
                this.meusContatos.RemoveAt(this.meusContatos.IndexOf(c));
            return podeRemover;
        }
    }
}
