using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVendas
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            txtvenda.Text = venda.ToString(); //mostrando id da venda inicial assim que o programa rodar
            lblvalortotal.Text = TotalVenda.ToString("C");
        }

        int venda = 1;
        double TotalVenda = 0;

        //FUNÇÕES
        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparCampos()
        {
            txtdescricao.Clear();
            txtquantidade.Clear();
            txtvalorunit.Clear();
        }

        private void TotalVendas()
        {
            //Função para recalcular e mostrar o valor total dos itens da venda
            TotalVenda -= (Convert.ToDouble(dgvVendas.CurrentRow.Cells["valorunit"].Value) * Convert.ToDouble(dgvVendas.CurrentRow.Cells["quantidade"].Value));
            lblvalortotal.Text = TotalVenda.ToString("C");
        }
       

        //BOTÕES
        private void btninserir_Click(object sender, EventArgs e)
        {
            
            lbltotal.Text = dgvVendas.RowCount.ToString();

            //Adicionando no DGV
            dgvVendas.Rows.Add(txtdescricao.Text, txtquantidade.Text, txtvalorunit.Text);

            //Calculando e mostrando total
            int qnt = int.Parse(txtquantidade.Text);
            double valorunit = double.Parse(txtvalorunit.Text);
            TotalVenda += qnt * valorunit;

            lblvalortotal.Text = TotalVenda.ToString("C");

            //Finalizando botão
            LimparCampos();
            lbltotal.Text = dgvVendas.RowCount.ToString();
        }
        

        private void btnremover_Click(object sender, EventArgs e)
        {

            //Apagando a linha do dgv
            if (dgvVendas.Rows.Count > 0)
            {
                TotalVendas();
                dgvVendas.Rows.RemoveAt(dgvVendas.CurrentRow.Index);
                lbltotal.Text = dgvVendas.RowCount.ToString();
                lblvalortotal.Text = TotalVenda.ToString("C");
            }

        }


        //Cancela os itens da lista mas mantém a mesma ID dela
        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TotalVendas();
            dgvVendas.Rows.Clear();
            lbltotal.Text = dgvVendas.RowCount.ToString();
        }


        //Fecha a ID anterior e abre uma nova
        private void btnnovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TotalVendas();
            dgvVendas.Rows.Clear();
            venda++;
            txtvenda.Text = venda.ToString();
        }


        private void DgvVendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Essa condição impede que dê erro no sistema caso o botão tente alterar linhas inexistentes
            if (dgvVendas.Rows.Count > 0)
            {
                txtalteracao.Text = dgvVendas.CurrentRow.Cells["quantidade"].Value.ToString();
            }
        }


        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (txtalteracao.Text != "")
            {
                int qntalterada = int.Parse(txtalteracao.Text);

                if (qntalterada > 0) 
                {
                    //Tirando o valor antigo da variável total
                    TotalVenda -= (Convert.ToDouble(dgvVendas.CurrentRow.Cells["valorunit"].Value) * Convert.ToDouble(dgvVendas.CurrentRow.Cells["quantidade"].Value));

                    //Caminho contrário da seleção da linha
                    dgvVendas.CurrentRow.Cells["quantidade"].Value = txtalteracao.Text;
                    
                    //Adicionando o total com quantidade alterada
                    TotalVenda += (Convert.ToDouble(dgvVendas.CurrentRow.Cells["valorunit"].Value) * Convert.ToDouble(dgvVendas.CurrentRow.Cells["quantidade"].Value));

                    //Atualizando o total após a alterção
                    lblvalortotal.Text = TotalVenda.ToString("C");

                }
                else
                {
                    MessageBox.Show("Insira uma quantidade válida ou clique em REMOVER", "Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                    

            }

        }
    }
}
