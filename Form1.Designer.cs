namespace ProjetoVendas
{
    partial class Vendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.Venda = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtvenda = new System.Windows.Forms.TextBox();
            this.txtquantidade = new System.Windows.Forms.TextBox();
            this.txtvalorunit = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtalteracao = new System.Windows.Forms.TextBox();
            this.lblvalortotal = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.Venda.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AllowUserToOrderColumns = true;
            this.dgvVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.quantidade,
            this.valorunit});
            this.dgvVendas.Location = new System.Drawing.Point(35, 247);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(564, 223);
            this.dgvVendas.TabIndex = 6;
            this.dgvVendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVendas_CellClick);
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 87;
            // 
            // valorunit
            // 
            this.valorunit.HeaderText = "Valor Unit.";
            this.valorunit.Name = "valorunit";
            this.valorunit.ReadOnly = true;
            this.valorunit.Width = 81;
            // 
            // btninserir
            // 
            this.btninserir.Location = new System.Drawing.Point(308, 120);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(112, 51);
            this.btninserir.TabIndex = 4;
            this.btninserir.Text = "Inserir";
            this.btninserir.UseVisualStyleBackColor = true;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnremover
            // 
            this.btnremover.Location = new System.Drawing.Point(435, 120);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(112, 51);
            this.btnremover.TabIndex = 5;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = true;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(444, 576);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(138, 41);
            this.btnalterar.TabIndex = 10;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Location = new System.Drawing.Point(444, 639);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(138, 38);
            this.btnfechar.TabIndex = 11;
            this.btnfechar.Text = "Fechar Sistema";
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(344, 497);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(123, 43);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.Text = "Cancelar Venda";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(168, 497);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(123, 43);
            this.btnnovo.TabIndex = 7;
            this.btnnovo.Text = "Nova  Venda";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // Venda
            // 
            this.Venda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Venda.Controls.Add(this.label4);
            this.Venda.Controls.Add(this.label3);
            this.Venda.Controls.Add(this.label2);
            this.Venda.Controls.Add(this.label1);
            this.Venda.Controls.Add(this.txtvenda);
            this.Venda.Controls.Add(this.txtquantidade);
            this.Venda.Controls.Add(this.txtvalorunit);
            this.Venda.Controls.Add(this.txtdescricao);
            this.Venda.Controls.Add(this.btnremover);
            this.Venda.Controls.Add(this.btninserir);
            this.Venda.Location = new System.Drawing.Point(35, 30);
            this.Venda.Name = "Venda";
            this.Venda.Size = new System.Drawing.Size(564, 198);
            this.Venda.TabIndex = 7;
            this.Venda.TabStop = false;
            this.Venda.Text = "Cadastrar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor Unit.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Venda:";
            // 
            // txtvenda
            // 
            this.txtvenda.Enabled = false;
            this.txtvenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvenda.Location = new System.Drawing.Point(115, 29);
            this.txtvenda.Name = "txtvenda";
            this.txtvenda.ReadOnly = true;
            this.txtvenda.Size = new System.Drawing.Size(66, 24);
            this.txtvenda.TabIndex = 0;
            // 
            // txtquantidade
            // 
            this.txtquantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantidade.Location = new System.Drawing.Point(115, 115);
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(170, 22);
            this.txtquantidade.TabIndex = 2;
            // 
            // txtvalorunit
            // 
            this.txtvalorunit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalorunit.Location = new System.Drawing.Point(115, 157);
            this.txtvalorunit.Name = "txtvalorunit";
            this.txtvalorunit.Size = new System.Drawing.Size(170, 22);
            this.txtvalorunit.TabIndex = 3;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(115, 71);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(418, 24);
            this.txtdescricao.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 646);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Itens:";
            // 
            // txtalteracao
            // 
            this.txtalteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtalteracao.Location = new System.Drawing.Point(150, 585);
            this.txtalteracao.Name = "txtalteracao";
            this.txtalteracao.Size = new System.Drawing.Size(244, 22);
            this.txtalteracao.TabIndex = 9;
            // 
            // lblvalortotal
            // 
            this.lblvalortotal.AutoSize = true;
            this.lblvalortotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalortotal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblvalortotal.Location = new System.Drawing.Point(121, 649);
            this.lblvalortotal.Name = "lblvalortotal";
            this.lblvalortotal.Size = new System.Drawing.Size(0, 24);
            this.lblvalortotal.TabIndex = 12;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbltotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbltotal.Location = new System.Drawing.Point(323, 649);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(21, 24);
            this.lbltotal.TabIndex = 13;
            this.lbltotal.Text = "0";
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(634, 723);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblvalortotal);
            this.Controls.Add(this.txtalteracao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Venda);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.dgvVendas);
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Mercado - Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.Venda.ResumeLayout(false);
            this.Venda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.GroupBox Venda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvenda;
        private System.Windows.Forms.TextBox txtquantidade;
        private System.Windows.Forms.TextBox txtvalorunit;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtalteracao;
        private System.Windows.Forms.Label lblvalortotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorunit;
    }
}

