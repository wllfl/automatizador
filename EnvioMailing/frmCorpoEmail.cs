using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ini.Net;

namespace EnvioMailing
{
    public partial class frmCorpoEmail : Form
    {
        public frmCorpoEmail()
        {
            InitializeComponent();
            carregarDados();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "")
            {
                gravarDados();
            }
            else
            {
                MessageBox.Show("Não existe texto para o e-mail!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gravarDados()
        {
            try
            {
                var iniFile = new IniFile("./Config.ini");

                iniFile.WriteString("Email", "texto", txtEmail.Text);

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

                txtEmail.Text = iniFile.ReadString("Email", "texto");
            }
        }
    }
}
