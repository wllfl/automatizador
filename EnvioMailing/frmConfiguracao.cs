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
using System.Net;
using System.Web;
using Ini.Net;
using System.Threading;

namespace EnvioMailing
{
    public partial class frmConfiguracao : Form
    {
        private frmPrincipal fPrincipal = null;

        /*******************************************************************************************************************************************/

        public frmConfiguracao()
        {
            InitializeComponent();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            carregarDados();
        }

        /*******************************************************************************************************************************************/

        public frmConfiguracao(frmPrincipal form)
        {
            InitializeComponent();
            openFileDialog.Filter = "Text Files (.txt)|*.txt";
            carregarDados();
            this.fPrincipal = form;
        }

        /*******************************************************************************************************************************************/

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja gravar as modificações?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.gravarDados();
            }
            this.fPrincipal.carregarDados();
            this.Close();
        }

        /*******************************************************************************************************************************************/

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtQtdeLote.Value > 0 && txtNomeRemetente.Text != "")
            {
                gravarDados();
            }
            else
            {
                MessageBox.Show("Campo obrigatórios não foram preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*******************************************************************************************************************************************/

        private void gravarDados()
        {
            try
            {
                var iniFile = new IniFile("./Config.ini");

                iniFile.WriteInteger("Configuracao", "QtdeEmailBloco", Convert.ToInt32(txtQtdeLote.Value));
                iniFile.WriteInteger("Configuracao", "QtdeEmailScript", Convert.ToInt32(txtQtdeEmailScript.Value));
                iniFile.WriteInteger("Configuracao", "IntevaloLote", Convert.ToInt32(txtIntevaloLote.Value));
                iniFile.WriteInteger("Configuracao", "IntevaloEmail", Convert.ToInt32(txtIntevaloEmail.Value));
                iniFile.WriteString("Configuracao", "NomeRemetente", txtNomeRemetente.Text);

                String nomeLog = "./Mailing.txt";
                using (StreamWriter writer = new StreamWriter(nomeLog, false))
                {
                    for (int i = 0; i < dgvArquivos.Rows.Count; i++)
                    {

                        writer.WriteLine(dgvArquivos.Rows[i].Cells[1].Value.ToString());
                    }
                }

                String nomeScript = "./Script.txt";
                using (StreamWriter writer = new StreamWriter(nomeScript, false))
                {
                    for (int i = 0; i < dgvScripts.Rows.Count; i++)
                    {
                        writer.WriteLine(dgvScripts.Rows[i].Cells[1].Value.ToString());
                    }
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
            if (File.Exists("./Config.ini"))
            {
                var iniFile = new IniFile("./Config.ini");

                txtQtdeLote.Value = iniFile.ReadInteger("Configuracao", "QtdeEmailBloco");
                txtIntevaloLote.Value = iniFile.ReadInteger("Configuracao", "IntevaloLote");
                txtIntevaloEmail.Value = iniFile.ReadInteger("Configuracao", "IntevaloEmail");
                txtQtdeEmailScript.Value = iniFile.ReadInteger("Configuracao", "QtdeEmailScript");
                txtNomeRemetente.Text = iniFile.ReadString("Configuracao", "NomeRemetente");

                if (File.Exists("./Mailing.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Mailing.txt");
                    foreach (string line in lines)
                    {
                        dgvArquivos.Rows.Add(false, line);
                    }
                }

                if (File.Exists("./Script.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Script.txt");
                    foreach (string line in lines)
                    {
                        dgvScripts.Rows.Add(false, line);
                    }
                }
               
            }

        }

        /*******************************************************************************************************************************************/

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

        /*******************************************************************************************************************************************/

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

        /*******************************************************************************************************************************************/

        private void excluirLinhaScript()
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            dgvScripts.EndEdit();
            foreach (DataGridViewRow row in dgvScripts.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.TrueValue)
                {
                    toDelete.Add(row);
                }
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dgvScripts.Rows.Remove(row);
            }
        }

        /*******************************************************************************************************************************************/

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

        /*******************************************************************************************************************************************/

        private void excluirTudoScript()
        {
            List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

            dgvScripts.EndEdit();
            foreach (DataGridViewRow row in dgvScripts.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                toDelete.Add(row);
            }

            foreach (DataGridViewRow row in toDelete)
            {
                dgvScripts.Rows.Remove(row);
            }
        }

        /*******************************************************************************************************************************************/

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
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

        /*******************************************************************************************************************************************/

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os itens selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirLinha();
            }
        }

        /*******************************************************************************************************************************************/

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os TXTs da Listagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirTudo();
            }
        }

        /*******************************************************************************************************************************************/

        private void btnLimparScripts_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os Scripts da Listagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirTudoScript();
            }
        }

        /*******************************************************************************************************************************************/

        private void btnExcluirScript_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os itens selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirLinhaScript();
            }
        }

        /*******************************************************************************************************************************************/

        private void btnIncluirScript_Click(object sender, EventArgs e)
        {
            if (txtUrl.Text != "")
            {
                if (this.isUrlValida(txtUrl.Text))
                {
                    dgvScripts.Rows.Add(false, txtUrl.Text);
                }
            }
        }

        /*******************************************************************************************************************************************/

        private Boolean isUrlValida(string file)
        {
            bool retorno = true;

            for (int i = 0; i < dgvScripts.Rows.Count; i++)
            {
                if (file == dgvScripts.Rows[i].Cells[1].Value.ToString())
                {
                    retorno = false;
                    break;
                }
            }

            return retorno;
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os itens selecionados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirLinha();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja remover todos os TXTs da Listagem?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.excluirTudo();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPara.Text != "" && txtDe.Text != "" && dgvScripts.Rows.Count > 0)
            {
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("É necessário preencher o campo \"PARA\", \"DE\" e possuir Scripts PHP gravados! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (File.Exists("./Script.txt"))
            {
                string[] lines = File.ReadAllLines(@"./Script.txt");
                int contadorSucesso = 0;
                int contadorErros = 0;

                foreach (string line in lines)
                {

                    WebRequest request = WebRequest.Create(line);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";

                    string postData = HttpUtility.UrlEncode("NRemetente") + "=" + HttpUtility.UrlEncode(txtDe.Text) + "&";
                    postData += HttpUtility.UrlEncode("ERemetente") + "=" + HttpUtility.UrlEncode(txtDe.Text) + "&";
                    postData += HttpUtility.UrlEncode("Conteudo") + "=" + HttpUtility.UrlEncode("Testando Envio") + "&";
                    postData += HttpUtility.UrlEncode("Emails") + "=" + HttpUtility.UrlEncode(txtPara.Text) + "&";
                    postData += HttpUtility.UrlEncode("Assunto") + "=" + HttpUtility.UrlEncode(line) + "&";
                    postData += HttpUtility.UrlEncode("Interval") + "=" + HttpUtility.UrlEncode("0");

                    byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                    request.ContentLength = byteArray.Length;

                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();

                    WebResponse response = request.GetResponse();

                    dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();

                    string[] retorno = responseFromServer.Split('#');
                    contadorSucesso += Convert.ToInt32(retorno[1]);
                    contadorErros += Convert.ToInt32(retorno[2]);

                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }

                MessageBox.Show("E-mails enviados ("+contadorSucesso+")!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*******************************************************************************************************************************************/

    }
}
