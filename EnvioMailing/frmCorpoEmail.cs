﻿using System;
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

        private frmPrincipal fPrincipal = null;

        /*******************************************************************************************************************************************/

        public frmCorpoEmail()
        {
            InitializeComponent();
            carregarDados();
        }

        /*******************************************************************************************************************************************/

        public frmCorpoEmail(frmPrincipal form)
        {
            InitializeComponent();
            carregarDados();
            this.fPrincipal = form;
        }

        /*******************************************************************************************************************************************/

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.fPrincipal.carregarDados();
            this.Close();
        }

        /*******************************************************************************************************************************************/

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

        /*******************************************************************************************************************************************/

        private void gravarDados()
        {
            try
            {
                String nomeScript = "./Email.txt";
                using (StreamWriter writer = new StreamWriter(nomeScript, false))
                {
                    writer.WriteLine(txtEmail.Text);
                }

                MessageBox.Show("Gravado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar dados: " + ex.Message);
            }
        }

        /*******************************************************************************************************************************************/

        private void carregarDados()
        {
            if (File.Exists("./Email.txt"))
            {
                string[] lines = File.ReadAllLines(@"./Email.txt");
                foreach (string line in lines)
                {
                    txtEmail.Text += line + "\r\n";
                }
            }
        }

        /*******************************************************************************************************************************************/
    }
}
