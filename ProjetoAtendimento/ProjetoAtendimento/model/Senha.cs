using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtendimento
{
    class Senha
    {
        private int id;
        private DateTime dataGeracao;
        private DateTime horaGeracao;
        private DateTime dataAtendimento;
        private DateTime horaAtendimento;

        #region Propriedades
        public DateTime DataGeracao
        {
            get
            {
                return dataGeracao;
            }

            set
            {
                dataGeracao = value;
            }
        }

        public DateTime HoraGeracao
        {
            get
            {
                return horaGeracao;
            }

            set
            {
                horaGeracao = value;
            }
        }

        public DateTime DataAtendimento
        {
            get
            {
                return dataAtendimento;
            }

            set
            {
                dataAtendimento = value;
            }
        }

        public DateTime HoraAtendimento
        {
            get
            {
                return horaAtendimento;
            }

            set
            {
                horaAtendimento = value;
            }
        }
        #endregion
        public Senha(int id)
        {
            this.DataGeracao = DateTime.Now;
            this.HoraGeracao = DateTime.Now;
            this.DataAtendimento = new DateTime(0);
            this.HoraAtendimento = new DateTime(0);
            this.id = id;
        }

        public string dadosParciais()
        {
            return this.id + " - " + this.DataGeracao.ToShortDateString() + " - " + this.HoraGeracao.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return this.dadosParciais() + " - " + this.DataAtendimento.ToShortDateString() + " - " + this.HoraAtendimento.ToLongTimeString();
        }
    }
}
