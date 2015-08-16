using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ini.Net;
using System.IO;

namespace EnvioMailing
{
    public partial class frmAssunto : Form
    {

        private frmPrincipal fPrincipal = null;

        public frmAssunto()
        {
            InitializeComponent();
            carregarDados();
        }

        public frmAssunto(frmPrincipal form)
        {
            InitializeComponent();
            carregarDados();
            this.fPrincipal = form;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.fPrincipal.carregarDados();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtAssunto1.Text != "" || txtAssunto2.Text != "" || txtAssunto3.Text != "")
            {
                gravarDados();
            }
            else
            {
                MessageBox.Show("Não existem Assuntos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gravarDados()
        {
            try
            {
                var iniFile = new IniFile("./Config.ini");

                iniFile.WriteString("Assunto", "assunto1", txtAssunto1.Text);
                iniFile.WriteString("Assunto", "assunto2", txtAssunto2.Text);
                iniFile.WriteString("Assunto", "assunto3", txtAssunto3.Text);

                MessageBox.Show("Gravado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar dados: " + ex.Message);
            }
        }

        private void carregarDados()
        {
            if (File.Exists("./Config.ini"))
            {
                var iniFile = new IniFile("./Config.ini");

                txtAssunto1.Text = iniFile.ReadString("Assunto", "assunto1");
                txtAssunto2.Text = iniFile.ReadString("Assunto", "assunto2");
                txtAssunto3.Text = iniFile.ReadString("Assunto", "assunto3");
            }
            else
            {
                MessageBox.Show("Não possível encontrar o arquivo de configuração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAssunto_Load(object sender, EventArgs e)
        {

        }

    }
}
