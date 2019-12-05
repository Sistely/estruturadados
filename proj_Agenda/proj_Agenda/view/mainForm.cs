using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Agenda
{
    public partial class mainForm : Form
    {
        controller.Contatos contatos = new controller.Contatos();

        public mainForm()
        {
            InitializeComponent();
        }
        
        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_email.Clear();
            txt_nome.Clear();
            txt_numero.Clear();
            grd_telefones.Rows.Clear();
 
        }

        
        private void btn_gravar_Click(object sender, EventArgs e)
        {
            try
            {
                String emailContato = txt_email.Text;
                String nomeContato = txt_nome.Text;
                 
                List<model.Fone> telefonesContato = new List<model.Fone>();

                foreach (DataGridViewRow item in grd_telefones.Rows)
                {
                    
                    telefonesContato.Add(new model.Fone(item.Cells[0].Value.ToString(), item.Cells[1].Value.ToString()));
                }

                
                if(!nomeContato.Equals("") && !emailContato.Equals("") && telefonesContato.Count > 0)
                {
                    contatos.adicionar(new model.Contato(emailContato, nomeContato, telefonesContato));

                    MessageBox.Show("Contato registrado com sucesso!");

                    txt_email.Clear();
                    txt_nome.Clear();
                    txt_numero.Clear();
                    grd_telefones.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Verifique se preencheu todos os campos corretamente.");
                }


            } catch(Exception ex)
            {
                MessageBox.Show("Verifique se preencheu todos os campos corretamente.");
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            String numeroTelefone = txt_numero.Text;
            String tipoTelefone = cmb_tipo.SelectedItem.ToString();

            try
            {
                grd_telefones.Rows.Add(numeroTelefone, tipoTelefone);


            } catch (Exception ex)
            {
                Console.WriteLine($"Exception: '{ex}'");
            }
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            String numeroTelefone = txt_numero.Text;
            String tipoTelefone = cmb_tipo.SelectedItem.ToString();

            try
            {
                foreach (DataGridViewRow item in grd_telefones.Rows)
                {
                    if (item.Cells[0].Value.ToString().Equals(numeroTelefone))
                    {
                        grd_telefones.Rows.Remove(item);
                        grd_telefones.Refresh();
                    }
                }
            } catch(Exception ex)
            {
                Console.WriteLine($"Exception: '{ex}'");
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            String emailContato = txt_email.Text;

            try
            {
                if (contatos.remover(new model.Contato(emailContato))) {
                    MessageBox.Show("Contato excluído");
                }
                else
                {
                    MessageBox.Show("Esse contato não existe ou já foi removido.");
                }
            } catch (Exception ex)
            {
                Console.WriteLine($"Exception: '{ex}'");
            }
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            String emailContato = txt_email.Text;

            try
            {
                model.Contato achado = contatos.pesquisar(new model.Contato(emailContato));
                if(achado == null){
                    MessageBox.Show("O contato inserido não existe.");
                }
                else
                {
                    txt_nome.Text = achado.Nome;
                    for (int itemPosition = 0; itemPosition < achado.Telefone.Count; itemPosition++)
                    {
                        grd_telefones.Rows.Add(achado.Telefone.ElementAt(itemPosition).Numero, achado.Telefone.ElementAt(itemPosition).Tipo);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Verifique se preencheu todos os campos corretamente.");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
