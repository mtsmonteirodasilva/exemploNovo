using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEmpresaAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                cadastro c = new cadastro();
                string regime;
                string tipo;
                string porte;

                c.Cnpj = tx_cnpj.Text;
                c.RazaoSocial = tx_razaoSocial.Text;
                c.NomeFantasia = tx_nomeFantasia.Text;
                c.SituacaoCadastral = cb_situacaoCadastral.Text;
                c.Telefone = ms_telefone.Text;
                c.DataInicioAtividade = ms_dataInicioAtividade.Text;
                c.CapitalSocial = tx_capitalSocial.Text;
                c.Estado = cb_estado.Text;
                c.NaturezaJuridica = cb_naturezaJuridica.Text;
                c.Cidade = tx_cidade.Text;
                c.Bairro = tx_bairro.Text;
                c.Rua = tx_rua.Text;
                c.Nome = tx_nome.Text;
                c.Cpf = ms_cpf.Text;

                if (rd_simples.Checked == true)
                {
                    regime = rd_simples.Text;
                }
                else if (rd_lucro.Checked == true)
                {
                    regime = rd_lucro.Text;
                }
                else
                {
                    regime = rd_lucroReal.Text;
                }

                if (rd_matriz.Checked == true)
                {
                    tipo = rd_matriz.Text;
                }
                else
                {
                    tipo = rd_filial.Text;
                }

                if (rd_pequeno.Checked == true)
                {
                    porte = rd_pequeno.Text;
                }
                else if (rd_medio.Checked == true)
                {
                    porte = rd_medio.Text;
                }
                else
                {
                    porte = rd_grande.Text;
                }

                if (Validar())
                {
                    MessageBox.Show("Cadastro realizado com sucesso");
                    MessageBox.Show($"Seu cnpj é {c.Cnpj}\nSua razão social é {c.RazaoSocial}\nSeu nome fantasia é {c.NomeFantasia}\nSua situação cadastral é {regime}" +
                        $"\nSua data de inicio é {c.DataInicioAtividade}\nSeu telefone é {c.Telefone}\nSeu capital social é {c.CapitalSocial}\nSeu endereço completo é {c.Estado}, {c.Cidade}, {c.Bairro}, {c.Rua}" +
                        $"\nO tipo de sua empresa é {tipo}\nO porte de sua empresa é {porte}\nSua natureza juridica é {c.NaturezaJuridica}\nSeu nome é {c.Nome}\nSeu cpf é {c.Cpf}");
                }
                else
                {
                    MessageBox.Show("Erro, prencha todos campos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro tente novamente");
            }




        }

        public bool Validar()
        {
            bool validacao;

            if (tx_cnpj.Text == "")
            {
                validacao = false;
            }
            else if (tx_razaoSocial.Text == "")
            {
                validacao = false;
            }
            else if (tx_nomeFantasia.Text == "")
            {
                validacao = false;
            }
            else if (cb_situacaoCadastral.Text == "")
            {
                validacao = false;
            }
            else if (ms_telefone.Text == "")
            {
                validacao = false;
            }
            else if (ms_dataInicioAtividade.Text == "")
            {
                validacao = false;
            }
            else if (tx_capitalSocial.Text == "")
            {
                validacao = false;
            }
            else if (cb_estado.Text == "")
            {
                validacao = false;
            }
            else if (cb_naturezaJuridica.Text == "")
            {
                validacao = false;
            }
            else if (tx_cidade.Text == "")
            {
                validacao = false;
            }
            else if (tx_bairro.Text == "")
            {
                validacao = false;
            }
            else if (tx_rua.Text == "")
            {
                validacao = false;
            }
            else if (tx_nome.Text == "")
            {
                validacao = false;
            }
            else if (ms_cpf.Text == "")
            {
                validacao = false;
            }
            else
            {
                validacao = true;
            }
            return validacao;
        }
    }

}
