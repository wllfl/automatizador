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
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIntevaloEmail = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntevaloLote = new System.Windows.Forms.NumericUpDown();
            this.txtQtdeLote = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvScripts = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeRemetente = new System.Windows.Forms.TextBox();
            this.btnIncluirScript = new System.Windows.Forms.Button();
            this.btnExcluirScript = new System.Windows.Forms.Button();
            this.btnLimparScripts = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQtdeEmailScript = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeEmailScript)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.toolStripDropDownButton1,
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
            this.groupBox1.Size = new System.Drawing.Size(739, 171);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listagem dos arquivo TXT";
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
            this.dgvArquivos.Size = new System.Drawing.Size(714, 121);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtQtdeEmailScript);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomeRemetente);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIntevaloEmail);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtIntevaloLote);
            this.groupBox2.Controls.Add(this.txtQtdeLote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 167);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(9, 689);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Campos obrigatórios";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoSize = false;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(135, 40);
            this.toolStripDropDownButton1.Text = "Arquivos TXT";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 36);
            this.toolStripMenuItem1.Text = "Adicionar TXT";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 36);
            this.toolStripMenuItem2.Text = "Excluir TXT";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(166, 36);
            this.toolStripMenuItem3.Text = "Limpar TXTs";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUrl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnLimparScripts);
            this.groupBox4.Controls.Add(this.btnExcluirScript);
            this.groupBox4.Controls.Add(this.btnIncluirScript);
            this.groupBox4.Controls.Add(this.dgvScripts);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 235);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(739, 260);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listagem dos Scripts PHP";
            // 
            // dgvScripts
            // 
            this.dgvScripts.AllowUserToAddRows = false;
            this.dgvScripts.AllowUserToDeleteRows = false;
            this.dgvScripts.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScripts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1});
            this.dgvScripts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvScripts.Location = new System.Drawing.Point(12, 122);
            this.dgvScripts.Name = "dgvScripts";
            this.dgvScripts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScripts.ShowCellErrors = false;
            this.dgvScripts.ShowCellToolTips = false;
            this.dgvScripts.ShowRowErrors = false;
            this.dgvScripts.Size = new System.Drawing.Size(714, 125);
            this.dgvScripts.TabIndex = 12;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Excluir";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "URL dos Scripts";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 700;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nome do Remente :";
            // 
            // txtNomeRemetente
            // 
            this.txtNomeRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRemetente.Location = new System.Drawing.Point(495, 75);
            this.txtNomeRemetente.Name = "txtNomeRemetente";
            this.txtNomeRemetente.Size = new System.Drawing.Size(225, 24);
            this.txtNomeRemetente.TabIndex = 21;
            // 
            // btnIncluirScript
            // 
            this.btnIncluirScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirScript.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluirScript.Image")));
            this.btnIncluirScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirScript.Location = new System.Drawing.Point(12, 29);
            this.btnIncluirScript.Name = "btnIncluirScript";
            this.btnIncluirScript.Size = new System.Drawing.Size(127, 37);
            this.btnIncluirScript.TabIndex = 13;
            this.btnIncluirScript.Text = "Adicionar";
            this.btnIncluirScript.UseVisualStyleBackColor = true;
            this.btnIncluirScript.Click += new System.EventHandler(this.btnIncluirScript_Click);
            // 
            // btnExcluirScript
            // 
            this.btnExcluirScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirScript.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirScript.Image")));
            this.btnExcluirScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirScript.Location = new System.Drawing.Point(145, 29);
            this.btnExcluirScript.Name = "btnExcluirScript";
            this.btnExcluirScript.Size = new System.Drawing.Size(127, 37);
            this.btnExcluirScript.TabIndex = 14;
            this.btnExcluirScript.Text = "Excluir";
            this.btnExcluirScript.UseVisualStyleBackColor = true;
            this.btnExcluirScript.Click += new System.EventHandler(this.btnExcluirScript_Click);
            // 
            // btnLimparScripts
            // 
            this.btnLimparScripts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparScripts.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparScripts.Image")));
            this.btnLimparScripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparScripts.Location = new System.Drawing.Point(278, 29);
            this.btnLimparScripts.Name = "btnLimparScripts";
            this.btnLimparScripts.Size = new System.Drawing.Size(127, 37);
            this.btnLimparScripts.TabIndex = 15;
            this.btnLimparScripts.Text = "Limpar";
            this.btnLimparScripts.UseVisualStyleBackColor = true;
            this.btnLimparScripts.Click += new System.EventHandler(this.btnLimparScripts_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "URL do Script (incluindo http://) :";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(197, 85);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(529, 24);
            this.txtUrl.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade de e-mails por Script PHP:";
            // 
            // txtQtdeEmailScript
            // 
            this.txtQtdeEmailScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEmailScript.Location = new System.Drawing.Point(242, 120);
            this.txtQtdeEmailScript.Name = "txtQtdeEmailScript";
            this.txtQtdeEmailScript.Size = new System.Drawing.Size(112, 24);
            this.txtQtdeEmailScript.TabIndex = 23;
            this.txtQtdeEmailScript.ValueChanged += new System.EventHandler(this.txtQtdeEmailScript_ValueChanged);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 713);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label5);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeEmailScript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGravar;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown txtIntevaloEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtIntevaloLote;
        private System.Windows.Forms.NumericUpDown txtQtdeLote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.TextBox txtNomeRemetente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvScripts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnLimparScripts;
        private System.Windows.Forms.Button btnExcluirScript;
        private System.Windows.Forms.Button btnIncluirScript;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQtdeEmailScript;
        private System.Windows.Forms.Label label4;
    }
}