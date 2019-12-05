using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Guiches filaGuiches;
        private Senhas filaSenhas;
        
        public Form1()
        {
            InitializeComponent();
            filaGuiches = new Guiches();
            filaSenhas = new Senhas();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            filaSenhas.gerar();
            MessageBox.Show("Sua senha foi gerada com sucesso! Aguarde ser chamado. :)");
            
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            filaGuiches.adicionar(new Guiche(filaGuiches.ListaGuiches.Count+1));
            lblQtd.Text = filaGuiches.ListaGuiches.Count.ToString();
        }

        private void btn_chamar_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(txtchamar.Text) <= filaGuiches.ListaGuiches.Count)
                    filaGuiches.ListaGuiches[int.Parse(txtchamar.Text) - 1].chamar(filaSenhas.FilaSenhas);
                else
                    MessageBox.Show("Erro");
            }
            catch(Exception exe)
            {
               MessageBox.Show("Erro");
            }
            
        }

        private void btn_listaratendimentos_Click(object sender, EventArgs e)
        {
            listchamar.Items.Clear();
            if (int.Parse(txtchamar.Text) <= filaGuiches.ListaGuiches.Count)
                foreach(Senha s in filaGuiches.ListaGuiches[int.Parse(txtchamar.Text) - 1].Atendimentos)
                    listchamar.Items.Add(s.dadosCompletos());
        }

        private void btn_listarsenhas_Click(object sender, EventArgs e)
        {
            listsenha.Items.Clear();
            foreach (Senha S in filaSenhas.FilaSenhas)
            {
                listsenha.Items.Add(S.dadosParciais());
            }
        }

    }
}
