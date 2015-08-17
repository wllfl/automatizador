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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtQtdeEmailScript = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeRemetente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntevaloEmail = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntevaloLote = new System.Windows.Forms.NumericUpDown();
            this.txtQtdeLote = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimparScripts = new System.Windows.Forms.Button();
            this.btnExcluirScript = new System.Windows.Forms.Button();
            this.btnIncluirScript = new System.Windows.Forms.Button();
            this.dgvScripts = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Arquivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeEmailScript)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripts)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGravar,
            this.btnFechar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(775, 43);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dgvArquivos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 250);
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
            this.dgvArquivos.Location = new System.Drawing.Point(9, 63);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArquivos.ShowCellErrors = false;
            this.dgvArquivos.ShowCellToolTips = false;
            this.dgvArquivos.ShowRowErrors = false;
            this.dgvArquivos.Size = new System.Drawing.Size(355, 175);
            this.dgvArquivos.TabIndex = 12;
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(373, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações de E-mail";
            // 
            // txtQtdeEmailScript
            // 
            this.txtQtdeEmailScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeEmailScript.Location = new System.Drawing.Point(250, 130);
            this.txtQtdeEmailScript.Name = "txtQtdeEmailScript";
            this.txtQtdeEmailScript.Size = new System.Drawing.Size(112, 24);
            this.txtQtdeEmailScript.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Quantidade de e-mails por Script PHP:";
            // 
            // txtNomeRemetente
            // 
            this.txtNomeRemetente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeRemetente.Location = new System.Drawing.Point(118, 24);
            this.txtNomeRemetente.Name = "txtNomeRemetente";
            this.txtNomeRemetente.Size = new System.Drawing.Size(244, 24);
            this.txtNomeRemetente.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Nome do Remente :";
            // 
            // txtIntevaloEmail
            // 
            this.txtIntevaloEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloEmail.Location = new System.Drawing.Point(250, 161);
            this.txtIntevaloEmail.Name = "txtIntevaloEmail";
            this.txtIntevaloEmail.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloEmail.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Intervalo por e-mail (Segundos):";
            // 
            // txtIntevaloLote
            // 
            this.txtIntevaloLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntevaloLote.Location = new System.Drawing.Point(250, 100);
            this.txtIntevaloLote.Name = "txtIntevaloLote";
            this.txtIntevaloLote.Size = new System.Drawing.Size(112, 24);
            this.txtIntevaloLote.TabIndex = 17;
            // 
            // txtQtdeLote
            // 
            this.txtQtdeLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdeLote.Location = new System.Drawing.Point(250, 71);
            this.txtQtdeLote.Name = "txtQtdeLote";
            this.txtQtdeLote.Size = new System.Drawing.Size(112, 24);
            this.txtQtdeLote.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Intervalo por lote (Segundos):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Quantidade de e-mails por lote * :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(4, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "* Campos obrigatórios";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtUrl);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnLimparScripts);
            this.groupBox4.Controls.Add(this.btnExcluirScript);
            this.groupBox4.Controls.Add(this.btnIncluirScript);
            this.groupBox4.Controls.Add(this.dgvScripts);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(399, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(370, 250);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listagem dos Scripts PHP";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(9, 79);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(351, 24);
            this.txtUrl.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "URL do Script (incluindo http://) :";
            // 
            // btnLimparScripts
            // 
            this.btnLimparScripts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparScripts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparScripts.Location = new System.Drawing.Point(262, 25);
            this.btnLimparScripts.Name = "btnLimparScripts";
            this.btnLimparScripts.Size = new System.Drawing.Size(96, 25);
            this.btnLimparScripts.TabIndex = 15;
            this.btnLimparScripts.Text = "Limpar";
            this.btnLimparScripts.UseVisualStyleBackColor = true;
            this.btnLimparScripts.Click += new System.EventHandler(this.btnLimparScripts_Click);
            // 
            // btnExcluirScript
            // 
            this.btnExcluirScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluirScript.Location = new System.Drawing.Point(134, 26);
            this.btnExcluirScript.Name = "btnExcluirScript";
            this.btnExcluirScript.Size = new System.Drawing.Size(96, 25);
            this.btnExcluirScript.TabIndex = 14;
            this.btnExcluirScript.Text = "Excluir";
            this.btnExcluirScript.UseVisualStyleBackColor = true;
            this.btnExcluirScript.Click += new System.EventHandler(this.btnExcluirScript_Click);
            // 
            // btnIncluirScript
            // 
            this.btnIncluirScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncluirScript.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluirScript.Location = new System.Drawing.Point(9, 25);
            this.btnIncluirScript.Name = "btnIncluirScript";
            this.btnIncluirScript.Size = new System.Drawing.Size(96, 26);
            this.btnIncluirScript.TabIndex = 13;
            this.btnIncluirScript.Text = "Adicionar";
            this.btnIncluirScript.UseVisualStyleBackColor = true;
            this.btnIncluirScript.Click += new System.EventHandler(this.btnIncluirScript_Click);
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
            this.dgvScripts.Location = new System.Drawing.Point(9, 113);
            this.dgvScripts.Name = "dgvScripts";
            this.dgvScripts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScripts.ShowCellErrors = false;
            this.dgvScripts.ShowCellToolTips = false;
            this.dgvScripts.ShowRowErrors = false;
            this.dgvScripts.Size = new System.Drawing.Size(349, 125);
            this.dgvScripts.TabIndex = 12;
            // 
            // Excluir
            // 
            this.Excluir.FalseValue = "0";
            this.Excluir.Frozen = true;
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.TrueValue = "1";
            this.Excluir.Width = 60;
            // 
            // Arquivos
            // 
            this.Arquivos.Frozen = true;
            this.Arquivos.HeaderText = "Caminho dos Arquivos";
            this.Arquivos.Name = "Arquivos";
            this.Arquivos.ReadOnly = true;
            this.Arquivos.Width = 700;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FalseValue = "0";
            this.dataGridViewCheckBoxColumn1.Frozen = true;
            this.dataGridViewCheckBoxColumn1.HeaderText = "Excluir";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "1";
            this.dataGridViewCheckBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "URL dos Scripts";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 700;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(266, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(138, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(13, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 26);
            this.button3.TabIndex = 16;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.txtDe);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPara);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(399, 314);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 192);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Teste de Envio";
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPara.Location = new System.Drawing.Point(61, 44);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(286, 24);
            this.txtPara.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Para:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "De:";
            // 
            // txtDe
            // 
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.Location = new System.Drawing.Point(61, 100);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(286, 24);
            this.txtDe.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(146, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 28);
            this.button4.TabIndex = 24;
            this.button4.Text = "Enviar Teste";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 530);
            this.Controls.Add(this.groupBox3);
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
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeEmailScript)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIntevaloLote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQtdeLote)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScripts)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeRemetente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvScripts;
        private System.Windows.Forms.Button btnLimparScripts;
        private System.Windows.Forms.Button btnExcluirScript;
        private System.Windows.Forms.Button btnIncluirScript;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtQtdeEmailScript;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Excluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arquivos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}