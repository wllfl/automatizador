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
    public partial class frmConfiguracao : Form
    {
        private frmPrincipal fPrincipal = null;

        public frmConfiguracao()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            carregarDados();
        }

        public frmConfiguracao(frmPrincipal form)
        {
            InitializeComponent();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            carregarDados();
            this.fPrincipal = form;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja gravar as modificações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.gravarDados();
            }
            this.fPrincipal.carregarDados();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDiretorio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtQtdeLote.Value > 0 && txtUrl.Text != "" && txtNomeRemetente.Text != "")
            {
                gravarDados();
            }
            else
            {
                MessageBox.Show("Campo obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gravarDados()
        {
            try
            {
                var iniFile = new IniFile("./Config.ini");

                iniFile.WriteInteger("Configuracao", "QtdeEmailBloco", Convert.ToInt32(txtQtdeLote.Value));
                iniFile.WriteInteger("Configuracao", "IntevaloLote", Convert.ToInt32(txtIntevaloLote.Value));
                iniFile.WriteInteger("Configuracao", "IntevaloEmail", Convert.ToInt32(txtIntevaloEmail.Value));
                iniFile.WriteString("Configuracao", "NomeRemetente", txtNomeRemetente.Text);
                iniFile.WriteString("Configuracao", "URL", txtUrl.Text);

                String nomeLog = "./Mailing.txt";
                using (StreamWriter writer = new StreamWriter(nomeLog, false))
                {
                    for (int i = 0; i < dgvArquivos.Rows.Count; i++)
                    {

                        writer.WriteLine(dgvArquivos.Rows[i].Cells[1].Value.ToString());
                    }
               }

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

                txtQtdeLote.Value = iniFile.ReadInteger("Configuracao", "QtdeEmailBloco");
                txtIntevaloLote.Value = iniFile.ReadInteger("Configuracao", "IntevaloLote");
                txtIntevaloEmail.Value = iniFile.ReadInteger("Configuracao", "IntevaloEmail");
                txtNomeRemetente.Text = iniFile.ReadString("Configuracao", "NomeRemetente");
                txtUrl.Text = iniFile.ReadString("Configuracao", "URL");

                if (File.Exists("./Mailing.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Mailing.txt");
                    foreach (string line in lines)
                    {
                        dgvArquivos.Rows.Add(false, line);
                    }
                }
               
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionarArquivo_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in openFileDialog.FileNames)
                {
                    try
                    {
                        if (this.isFileValido(file.ToString()))
                        {
                            dgvArquivos.Rows.Add(false, file);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não possível carregar os arquivos!" + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private Boolean isFileValido(string file)
        {
            bool retorno = true;

            for (int i = 0; i < dgvArquivos.Rows.Count; i++)
            {
                if (file == dgvArquivos.Rows[i].Cells[1].Value.ToString())
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        private void btnExcluirArquivo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os itens selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirLinha();
            }
               
        }

        private void excluirLinha()
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            dgvArquivos.EndEdit();
            foreach (DataGridViewRow row in dgvArquivos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    toDelete.Add(row);
                }
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dgvArquivos.Rows.Remove(row);
            }
        }

        private void excluirTudo()
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            dgvArquivos.EndEdit();
            foreach (DataGridViewRow row in dgvArquivos.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                toDelete.Add(row);
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dgvArquivos.Rows.Remove(row);
            }
        }

        private void txtLimparTXT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os TXTs da Listagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirTudo();
            }
        }
    }
}
