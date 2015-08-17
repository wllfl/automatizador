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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtLimparTXT = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIntevaloEmail = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntevaloLote = new System.Windows.Forms.NumericUpDown();
            this.txtQtdeLote = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNomeRemetente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
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
            this.groupBox1.Controls.Add(this.dgvArquivos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 311);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listagem dos arquivo TXT";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIntevaloEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIntevaloLote);
            this.groupBox2.Controls.Add(this.txtQtdeLote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 385);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 116);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações de E-mail";
            // 
            // txtIntevaloEmail
            // 
            this.txtIntevaloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloEmail.Location = new System.Drawing.Point(608, 29);
            this.txtIntevaloEmail.Name = "txtIntevaloEmail";
            this.txtIntevaloEmail.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Intervalo de envio por e-mail (Segundos):";
            // 
            // txtIntevaloLote
            // 
            this.txtIntevaloLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloLote.Location = new System.Drawing.Point(242, 76);
            this.txtIntevaloLote.Name = "txtIntevaloLote";
            this.txtIntevaloLote.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloLote.TabIndex = 17;
            // 
            // txtQtdeLote
            // 
            this.txtQtdeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeLote.Location = new System.Drawing.Point(240, 34);
            this.txtQtdeLote.Name = "txtQtdeLote";
            this.txtQtdeLote.Size = new System.Drawing.Size(114, 24);
            this.txtQtdeLote.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Intervalo de envio por lote (Segundos):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantidade de e-mails por lote * :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtUrl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNomeRemetente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 519);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(739, 96);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Configurações Gerais";
            // 
            // txtNomeRemetente
            // 
            this.txtNomeRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRemetente.Location = new System.Drawing.Point(230, 22);
            this.txtNomeRemetente.Name = "txtNomeRemetente";
            this.txtNomeRemetente.Size = new System.Drawing.Size(490, 24);
            this.txtNomeRemetente.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome do Remente :";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(230, 58);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(490, 24);
            this.txtUrl.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "URL do Script PHP (incluindo http:// ) *:";
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
            this.dgvArquivos.Location = new System.Drawing.Point(12, 31);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArquivos.ShowCellErrors = false;
            this.dgvArquivos.ShowCellToolTips = false;
            this.dgvArquivos.ShowRowErrors = false;
            this.dgvArquivos.Size = new System.Drawing.Size(714, 267);
            this.dgvArquivos.TabIndex = 12;
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 630);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Campos obrigatórios";
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 650);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripButton btnAdicionarArquivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripButton btnExcluirArquivo;
        private System.Windows.Forms.ToolStripButton txtLimparTXT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtIntevaloEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtIntevaloLote;
        private System.Windows.Forms.NumericUpDown txtQtdeLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeRemetente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivos;
        private System.Windows.Forms.Label label5;
    }
}