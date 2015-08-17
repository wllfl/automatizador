namespace EnvioMailing
{
    partial class frmConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGravar = new System.Windows.Forms.ToolStripButton();
            this.btnAdicionarArquivo = new System.Windows.Forms.ToolStripButton();
            this.btnExcluirArquivo = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNomeRemetente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntevaloEmail = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtIntevaloLote = new System.Windows.Forms.NumericUpDown();
            this.txtQtdeLote = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtLimparTXT = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnAdicionarArquivo,
            this.btnExcluirArquivo,
            this.txtLimparTXT,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(763, 43);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGravar
            // 
            this.btnGravar.AutoSize = false;
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(110, 40);
            this.btnGravar.Text = "Gravar";
            this.btnGravar.ToolTipText = "Gravar Configurações e Fechar";
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnAdicionarArquivo
            // 
            this.btnAdicionarArquivo.AutoSize = false;
            this.btnAdicionarArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarArquivo.Image")));
            this.btnAdicionarArquivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionarArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionarArquivo.Name = "btnAdicionarArquivo";
            this.btnAdicionarArquivo.Size = new System.Drawing.Size(140, 40);
            this.btnAdicionarArquivo.Text = "Adicionar TXT";
            this.btnAdicionarArquivo.Click += new System.EventHandler(this.btnAdicionarArquivo_Click);
            // 
            // btnExcluirArquivo
            // 
            this.btnExcluirArquivo.AutoSize = false;
            this.btnExcluirArquivo.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirArquivo.Image")));
            this.btnExcluirArquivo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluirArquivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirArquivo.Name = "btnExcluirArquivo";
            this.btnExcluirArquivo.Size = new System.Drawing.Size(130, 40);
            this.btnExcluirArquivo.Text = "Excluir TXT";
            this.btnExcluirArquivo.Click += new System.EventHandler(this.btnExcluirArquivo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(78, 40);
            this.btnFechar.Text = "Fechar";
            this.btnFechar.ToolTipText = "Fechar ";
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNomeRemetente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIntevaloEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvArquivos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtUrl);
            this.groupBox1.Controls.Add(this.txtIntevaloLote);
            this.groupBox1.Controls.Add(this.txtQtdeLote);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 432);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // txtNomeRemetente
            // 
            this.txtNomeRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRemetente.Location = new System.Drawing.Point(510, 71);
            this.txtNomeRemetente.Name = "txtNomeRemetente";
            this.txtNomeRemetente.Size = new System.Drawing.Size(213, 24);
            this.txtNomeRemetente.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nome do Remente :";
            // 
            // txtIntevaloEmail
            // 
            this.txtIntevaloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloEmail.Location = new System.Drawing.Point(611, 28);
            this.txtIntevaloEmail.Name = "txtIntevaloEmail";
            this.txtIntevaloEmail.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloEmail.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Intervalo de envio por e-mail (Segundos):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lista dos Arquivos Selecionados:";
            // 
            // dgvArquivos
            // 
            this.dgvArquivos.AllowUserToAddRows = false;
            this.dgvArquivos.AllowUserToDeleteRows = false;
            this.dgvArquivos.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Arquivos});
            this.dgvArquivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvArquivos.Location = new System.Drawing.Point(9, 197);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArquivos.ShowCellErrors = false;
            this.dgvArquivos.ShowCellToolTips = false;
            this.dgvArquivos.ShowRowErrors = false;
            this.dgvArquivos.Size = new System.Drawing.Size(714, 211);
            this.dgvArquivos.TabIndex = 10;
            this.dgvArquivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Excluir
            // 
            this.Excluir.FalseValue = "0";
            this.Excluir.Frozen = true;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.TrueValue = "1";
            this.Excluir.Width = 70;
            // 
            // Arquivos
            // 
            this.Arquivos.Frozen = true;
            this.Arquivos.HeaderText = "Caminho dos Arquivos";
            this.Arquivos.Name = "Arquivos";
            this.Arquivos.ReadOnly = true;
            this.Arquivos.Width = 700;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(6, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "* Campos obrigatórios";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(245, 113);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(478, 24);
            this.txtUrl.TabIndex = 6;
            // 
            // txtIntevaloLote
            // 
            this.txtIntevaloLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloLote.Location = new System.Drawing.Point(245, 71);
            this.txtIntevaloLote.Name = "txtIntevaloLote";
            this.txtIntevaloLote.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloLote.TabIndex = 5;
            this.txtIntevaloLote.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // txtQtdeLote
            // 
            this.txtQtdeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeLote.Location = new System.Drawing.Point(243, 33);
            this.txtQtdeLote.Name = "txtQtdeLote";
            this.txtQtdeLote.Size = new System.Drawing.Size(114, 24);
            this.txtQtdeLote.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "URL do Script PHP (incluindo http:// ) *:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Intervalo de envio por lote (Segundos):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de e-mails por lote * :";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Help";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Multiselect = true;
            // 
            // txtLimparTXT
            // 
            this.txtLimparTXT.AutoSize = false;
            this.txtLimparTXT.Image = ((System.Drawing.Image)(resources.GetObject("txtLimparTXT.Image")));
            this.txtLimparTXT.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.txtLimparTXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txtLimparTXT.Name = "txtLimparTXT";
            this.txtLimparTXT.Size = new System.Drawing.Size(150, 40);
            this.txtLimparTXT.Text = "Limpar TXTs";
            this.txtLimparTXT.Click += new System.EventHandler(this.txtLimparTXT_Click);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 502);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown txtQtdeLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtIntevaloLote;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.ToolStripButton btnAdicionarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btnExcluirArquivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivos;
        private System.Windows.Forms.NumericUpDown txtIntevaloEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeRemetente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton txtLimparTXT;
    }
}