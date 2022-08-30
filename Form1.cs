namespace _211065
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtVendaID.Text = id_venda.ToString();
        }

        int id_venda = 1;
        double TotalVenda = 0;

        private void LimparCampos()
        {
            //Limpa as caixas de texto
            txtQntItem.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();
            txtValorUnit.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            //finaliza a aplicação
            Application.Exit();
        }


        private void btnInserir_Click(object sender, EventArgs e)
        {
            string descricao = txtDescricao.Text;
            double quantidade = Convert.ToDouble(txtQuantidade.Text);
            double valor_unitario = Convert.ToDouble(txtValorUnit.Text);
            double total_unitario = quantidade * valor_unitario;

            //Adicionando o conteúdo das caixas de texto nas colunas correspondentes
            dgvVenda.Rows.Add(descricao, quantidade, valor_unitario, total_unitario);

            TotalVenda += total_unitario;

            //Mostrando total
            lblTotal.Text = TotalVenda.ToString("C");

            //Exibe na label0 (qnt de item selecionado) o contador de linhas do GridView atualizado após a inserção
            lblItens.Text = dgvVenda.RowCount.ToString();

            LimparCampos();

            //Exibe uma mensagem ao usuário de inclusão com sucesso
            //MessageBox.Show("Item inserido com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //verifica a existência de linhas no Grid
            if (dgvVenda.Rows.Count > 0)
            {
                //Remove a linha selecionada no Grid
                dgvVenda.Rows.RemoveAt(dgvVenda.CurrentCell.RowIndex);

                //Faz uma nova contagem de itens da venda
                lblItens.Text = dgvVenda.RowCount.ToString();


                if(dgvVenda.CurrentRow != null)
                {
                    string valor = dgvVenda.CurrentRow.Cells["dgvTotalUnit"].Value.ToString();
                    TotalVenda = Convert.ToDouble(valor);
                    lblTotal.Text = TotalVenda.ToString("C");
                } else
                {
                    TotalVenda = 0;
                    lblTotal.Text = TotalVenda.ToString("C");
                }
                    


                //TotalVenda = 

                //Mostrando um novo total
                // double quantidade = Convert.ToDouble(txtQuantidade.Text);
                // double valor_unitario = Convert.ToDouble(txtValorUnit.Text);
                // double total_unitario = quantidade * valor_unitario;
                //TotalVenda += total_unitario;
                //lblTotal.Text = TotalVenda.ToString("C");

                //Mostra uma mensagem de exclusão
                //MessageBox.Show("Item removido com sucesso", "Remoção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtQntItem.Text != "")
            {
                int qntalterada = int.Parse(txtQntItem.Text);

                if (qntalterada > 0)
                {
                    TotalVenda -= (Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvValorUnit"].Value) * Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvQuant"].Value));

                    dgvVenda.CurrentRow.Cells["dgvQuant"].Value = txtQntItem.Text;
                    dgvVenda.CurrentRow.Cells["dgvTotalUnit"].Value = TotalVenda;
                    TotalVenda += (Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvValorUnit"].Value) * Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvQuant"].Value));
                    lblTotal.Text = TotalVenda.ToString("C");



                    dgvVenda.CurrentRow.Cells["dgvTotalUnit"].Value = Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvQuant"].Value) * Convert.ToDouble(dgvVenda.CurrentRow.Cells["dgvValorUnit"].Value);


                }
                else
                {
                    MessageBox.Show("ERRO! Quantidade inválida", "Exclusão",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TotalVenda = 0;
            dgvVenda.Rows.Clear();
            lblItens.Text = dgvVenda.RowCount.ToString();
            lblTotal.Text = TotalVenda.ToString("C");
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
            LimparCampos();
            TotalVenda = 0;
            dgvVenda.Rows.Clear();
            lblItens.Text = dgvVenda.RowCount.ToString();
            lblTotal.Text = TotalVenda.ToString("C");
            id_venda++;
            txtVendaID.Text = id_venda.ToString();
        }

    }
}