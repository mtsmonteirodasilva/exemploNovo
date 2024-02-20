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
            string regime;
            string tipo;
            string porte;

            string cnpj = tx_cnpj.Text;
            string razaoSocial = tx_razaoSocial.Text;
            string nomeFantasia = tx_nomeFantasia.Text;
            string situacaoCadastral = cb_situacaoCadastral.Text;
            string telefone = ms_telefone.Text;
            string dataInicioAtividade = ms_dataInicioAtividade.Text;
            string capitalSocial = tx_capitalSocial.Text;
            string estado = cb_estado.Text;
            string naturezaJuridica = cb_naturezaJuridica.Text;
            string cidade = tx_cidade.Text;
            string bairro = tx_bairro.Text;
            string rua = tx_rua.Text;
            string nome = tx_nome.Text;
            string cpf = ms_cpf.Text;

            if(rd_simples.Checked == true)
            {
               regime = rd_simples.Text;
            }
            else if(rd_lucro.Checked == true)
            {
                regime = rd_lucro.Text;
            }
            else
            {
                regime = rd_lucroReal.Text;
            }

            if(rd_matriz.Checked == true)
            {
                tipo = rd_matriz.Text;
            }
            else
            {
                tipo = rd_filial.Text;
            }

            if(rd_pequeno.Checked == true)
            {
                porte = rd_pequeno.Text;
            }
            else if(rd_medio.Checked == true)
            {
                porte = rd_medio.Text;
            }
            else
            {
                porte = rd_grande.Text;
            }

            MessageBox.Show("Cadastro realizado com sucesso");
            MessageBox.Show($"Seu cnpj é {cnpj}\nSua razão social é {razaoSocial}\nSeu nome fantasia é {nomeFantasia}\nSua situação cadastral é {regime}" +
                $"\nSua data de inicio é {dataInicioAtividade}\nSeu telefone é {telefone}\nSeu capital social é {capitalSocial}\nSeu endereço completo é {estado}, {cidade}, {bairro}, {rua}" +
                $"\nO tipo de sua empresa é {tipo}\nO porte de sua empresa é {porte}\nSua natureza juridica é {naturezaJuridica}\nSeu nome é {nome}\nSeu cpf é {cpf}");
        }
    }
}
