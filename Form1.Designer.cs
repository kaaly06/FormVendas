namespace _211065
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtVendaID = new System.Windows.Forms.TextBox();
            this.txtValorUnit = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblValorUnit = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.dgvDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvValorUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQntItem = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovaVenda = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtQntItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblItens = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(495, 173);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 44);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(602, 173);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(95, 44);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // txtVendaID
            // 
            this.txtVendaID.Enabled = false;
            this.txtVendaID.Location = new System.Drawing.Point(294, 37);
            this.txtVendaID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVendaID.Name = "txtVendaID";
            this.txtVendaID.ReadOnly = true;
            this.txtVendaID.Size = new System.Drawing.Size(78, 23);
            this.txtVendaID.TabIndex = 2;
            this.txtVendaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtValorUnit
            // 
            this.txtValorUnit.Location = new System.Drawing.Point(123, 194);
            this.txtValorUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorUnit.Name = "txtValorUnit";
            this.txtValorUnit.Size = new System.Drawing.Size(138, 23);
            this.txtValorUnit.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(123, 150);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(145, 23);
            this.txtQuantidade.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(116, 95);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(581, 23);
            this.txtDescricao.TabIndex = 0;
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVenda.Location = new System.Drawing.Point(224, 31);
            this.lblVenda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(64, 36);
            this.lblVenda.TabIndex = 6;
            this.lblVenda.Text = "Venda:";
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldescricao.Location = new System.Drawing.Point(21, 90);
            this.lbldescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(88, 36);
            this.lbldescricao.TabIndex = 7;
            this.lbldescricao.Text = "Descrição:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuant.Location = new System.Drawing.Point(18, 145);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(103, 36);
            this.lblQuant.TabIndex = 8;
            this.lblQuant.Text = "Quantidade:";
            // 
            // lblValorUnit
            // 
            this.lblValorUnit.AutoSize = true;
            this.lblValorUnit.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorUnit.Location = new System.Drawing.Point(24, 194);
            this.lblValorUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorUnit.Name = "lblValorUnit";
            this.lblValorUnit.Size = new System.Drawing.Size(93, 36);
            this.lblValorUnit.TabIndex = 9;
            this.lblValorUnit.Text = "Valor Unit:";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.AllowUserToOrderColumns = true;
            this.dgvVenda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDescricao,
            this.dgvQuant,
            this.dgvValorUnit,
            this.dgvTotalUnit});
            this.dgvVenda.Location = new System.Drawing.Point(24, 280);
            this.dgvVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.RowTemplate.Height = 25;
            this.dgvVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVenda.Size = new System.Drawing.Size(673, 233);
            this.dgvVenda.TabIndex = 10;
            // 
            // dgvDescricao
            // 
            this.dgvDescricao.HeaderText = "Descrição";
            this.dgvDescricao.Name = "dgvDescricao";
            this.dgvDescricao.ReadOnly = true;
            this.dgvDescricao.Width = 83;
            // 
            // dgvQuant
            // 
            this.dgvQuant.HeaderText = "Quantidade";
            this.dgvQuant.Name = "dgvQuant";
            this.dgvQuant.ReadOnly = true;
            this.dgvQuant.Width = 94;
            // 
            // dgvValorUnit
            // 
            this.dgvValorUnit.HeaderText = "Valor Unitário";
            this.dgvValorUnit.Name = "dgvValorUnit";
            this.dgvValorUnit.ReadOnly = true;
            this.dgvValorUnit.Width = 103;
            // 
            // dgvTotalUnit
            // 
            this.dgvTotalUnit.HeaderText = "Total Unitário";
            this.dgvTotalUnit.Name = "dgvTotalUnit";
            this.dgvTotalUnit.ReadOnly = true;
            this.dgvTotalUnit.Width = 102;
            // 
            // lblQntItem
            // 
            this.lblQntItem.AutoSize = true;
            this.lblQntItem.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQntItem.Location = new System.Drawing.Point(38, 569);
            this.lblQntItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQntItem.Name = "lblQntItem";
            this.lblQntItem.Size = new System.Drawing.Size(246, 36);
            this.lblQntItem.TabIndex = 11;
            this.lblQntItem.Text = "Quantidade de item selecionado:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(602, 565);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(111, 31);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(375, 713);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 33);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar Venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovaVenda
            // 
            this.btnNovaVenda.Location = new System.Drawing.Point(506, 713);
            this.btnNovaVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNovaVenda.Name = "btnNovaVenda";
            this.btnNovaVenda.Size = new System.Drawing.Size(99, 33);
            this.btnNovaVenda.TabIndex = 8;
            this.btnNovaVenda.Text = "Nova Venda";
            this.btnNovaVenda.UseVisualStyleBackColor = true;
            this.btnNovaVenda.Click += new System.EventHandler(this.btnNovaVenda_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(624, 713);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(102, 33);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar Venda";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtQntItem
            // 
            this.txtQntItem.Location = new System.Drawing.Point(290, 573);
            this.txtQntItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQntItem.Name = "txtQntItem";
            this.txtQntItem.Size = new System.Drawing.Size(99, 23);
            this.txtQntItem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 625);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotal.Location = new System.Drawing.Point(101, 625);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 36);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 670);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Itens na grade:";
            // 
            // lblItens
            // 
            this.lblItens.AutoSize = true;
            this.lblItens.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblItens.Location = new System.Drawing.Point(164, 670);
            this.lblItens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItens.Name = "lblItens";
            this.lblItens.Size = new System.Drawing.Size(24, 36);
            this.lblItens.TabIndex = 20;
            this.lblItens.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 763);
            this.Controls.Add(this.lblItens);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQntItem);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnNovaVenda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblQntItem);
            this.Controls.Add(this.dgvVenda);
            this.Controls.Add(this.lblValorUnit);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorUnit);
            this.Controls.Add(this.txtVendaID);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnInserir);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mercado";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInserir;
        private Button btnRemover;
        private TextBox txtVendaID;
        private TextBox txtValorUnit;
        private TextBox txtQuantidade;
        private TextBox txtDescricao;
        private Label lblVenda;
        private Label lbldescricao;
        private Label lblQuant;
        private Label lblValorUnit;
        private DataGridView dgvVenda;
        private Label lblQntItem;
        private Button btnAlterar;
        private Button btnCancelar;
        private Button btnNovaVenda;
        private Button btnFechar;
        private TextBox txtQntItem;
        private Label label1;
        private Label lblTotal;
        private Label label2;
        private Label lblItens;
        private DataGridViewTextBoxColumn dgvDescricao;
        private DataGridViewTextBoxColumn dgvQuant;
        private DataGridViewTextBoxColumn dgvValorUnit;
        private DataGridViewTextBoxColumn dgvTotalUnit;
    }
}