using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Web;
using Ini.Net;
using System.Threading;

namespace EnvioMailing
{
    public partial class frmPrincipal : Form
    {
        private int QtdeBlocos = 0;
        private int QtdeScript = 0;
        private int IntevaloLote = 0;
        private int IntevaloEmail = 0;
        private string Remetente = null;
        private string Url = null;
        private string Diretorio = null;
        private int QtdeAssuntos = 0;
        private int QtdeEmail = 0;
        private string CorpoEmail = null;
        List<string> listaMailing = new List<string>();
        List<string> listaAssunto = new List<string>();
        List<string> listaScript = new List<string>();

        /*******************************************************************************************************************************************/

        public frmPrincipal()
        {
            InitializeComponent();
            carregarDados();
        }

        /*******************************************************************************************************************************************/

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.listaMailing.Count() > 0 && this.listaAssunto.Count() > 0 && this.CorpoEmail != "" && this.listaScript.Count() > 0)
            {
                listaEmailsEnviados.Items.Clear();
                listaRetorno.Items.Clear();
                btnEnvio.Visible = false;
                btnParar.Visible = true;
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("O sistema não possui as configurações mínimas para envio, verifique! \n- Lista de Mailing \n- Lista de Assuntos \n- Conteúdo do E-mail \n- URL PHP de disparo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*******************************************************************************************************************************************/

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /*******************************************************************************************************************************************/

        private void btnAssuntos_Click(object sender, EventArgs e)
        {
            frmAssunto fAssunto = new frmAssunto(this);
            fAssunto.Show();
        }

        /*******************************************************************************************************************************************/

        private void btnCorpoEmail_Click(object sender, EventArgs e)
        {
            frmCorpoEmail fCorpoEmail = new frmCorpoEmail(this);
            fCorpoEmail.Show();
        }

        /*******************************************************************************************************************************************/

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfiguracao fConfiguracao = new frmConfiguracao(this);
            fConfiguracao.Show();
        }

        /*******************************************************************************************************************************************/

        public void carregarDados()
        {
            if (File.Exists("./Config.ini"))
            {
                this.QtdeEmail = 0;
                this.QtdeAssuntos = 0;
                this.CorpoEmail = null;
                this.listaAssunto.Clear();
                this.listaMailing.Clear();

                var iniFile = new IniFile("./Config.ini");

                this.QtdeBlocos = iniFile.ReadInteger("Configuracao", "QtdeEmailBloco");
                this.QtdeScript = iniFile.ReadInteger("Configuracao", "QtdeEmailScript");
                this.IntevaloLote = iniFile.ReadInteger("Configuracao", "IntevaloLote");
                this.IntevaloEmail = iniFile.ReadInteger("Configuracao", "IntevaloEmail");
                this.Remetente = iniFile.ReadString("Configuracao", "NomeRemetente");
                this.Diretorio = iniFile.ReadString("Configuracao", "Diretorio");

                var assunto1 = iniFile.ReadString("Assunto", "assunto1");
                if (assunto1 != "")
                {
                    listaAssunto.Add(assunto1);
                }

                var assunto2 = iniFile.ReadString("Assunto", "assunto2");
                if (assunto2 != "")
                {
                    listaAssunto.Add(assunto2);
                }

                var assunto3 = iniFile.ReadString("Assunto", "assunto3");
                if (assunto3 != "")
                {
                    listaAssunto.Add(assunto3);
                }

                if (File.Exists("./Mailing.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Mailing.txt");
                    foreach (string line in lines)
                    {
                        listaMailing.Add(line);
                    }
                }

                List<DataGridViewRow> toDelete = new List<DataGridViewRow>();

                dgvHost.EndEdit();
                foreach (DataGridViewRow row in dgvHost.Rows)
                {
                    toDelete.Add(row);
                }

                foreach (DataGridViewRow row in toDelete)
                {
                    dgvHost.Rows.Remove(row);
                }

                if (File.Exists("./Script.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Script.txt");
                    foreach (string line in lines)
                    {
                        listaScript.Add(line);
                        dgvHost.Rows.Add(line);
                    }
                }

                if (File.Exists("./Email.txt"))
                {
                    string[] lines = File.ReadAllLines(@"./Email.txt");
                    foreach (string line in lines)
                    {
                        this.CorpoEmail += line;
                    }
                }


                this.QtdeEmail = listaMailing.Count();
                this.QtdeAssuntos = listaAssunto.Count();
                dgvHost.Rows.Add(Url);
                statusStrip.Items[7].Text = Convert.ToString(this.QtdeAssuntos);
                statusStrip.Items[9].Text = Convert.ToString(this.QtdeEmail);
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar o arquivo de configuração! \nFavor configurar todas as opções do sistema.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        /*******************************************************************************************************************************************/

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string nameFile = null;
            string listaEmails = null;
            string url = null;
            int contador = 0;
            int contadorGeral = 0;
            int contadorErros = 0;
            int contadorSucesso = 0;
            int totalLinhas = 0;
            int indiceScript = 0;

            statusStrip.Items[1].Text = "EXECUTANDO";

            foreach (string mailing in this.listaMailing)
            {
                if (File.Exists(mailing))
                {
                    nameFile = Path.GetFileNameWithoutExtension(mailing);
                    string[] emails = File.ReadAllLines(@mailing);
                    totalLinhas = System.IO.File.ReadAllLines(@mailing).Length;

                    foreach (string email in emails)
                    {
                        if (contador <= this.QtdeBlocos)
                        {
                            listaEmails += email + "\n";
                            listaEmailsEnviados.Invoke((Action<string>)addLista, email);
                            contador++;
                            contadorGeral++;
                        }

                        if (contador == this.QtdeBlocos || contadorGeral == totalLinhas)
                        {
                            Random random = new Random();
                            int randomNumber = random.Next(0, this.listaAssunto.Count());
                            string assunto = this.listaAssunto.ElementAt(randomNumber) + " - (" + random.Next(1000, 9999) + ")";

                            if (contadorGeral == this.QtdeScript)
                            {
                                if (this.listaScript.Count() == (indiceScript - 1))
                                {
                                    indiceScript = 1;
                                }
                                else
                                {
                                    indiceScript++;
                                }

                                url = this.listaScript.ElementAt(indiceScript);
                            }
                            else
                            {
                                url = this.listaScript.ElementAt(indiceScript);
                            }

                            WebRequest request = WebRequest.Create(url);
                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";

                            txtNome.Invoke((Action<string>)setNomeText, this.Remetente);
                            txtRementente.Invoke((Action<string>)setRemetenteText, nameFile);
                            txtAssunto.Invoke((Action<string>)setAssuntoText, assunto);

                            string postData = HttpUtility.UrlEncode("NRemetente") + "=" + HttpUtility.UrlEncode(this.Remetente) + "&";
                            postData += HttpUtility.UrlEncode("ERemetente") + "=" + HttpUtility.UrlEncode(nameFile) + "&";
                            postData += HttpUtility.UrlEncode("Conteudo") + "=" + HttpUtility.UrlEncode(this.CorpoEmail) + "&";
                            postData += HttpUtility.UrlEncode("Emails") + "=" + HttpUtility.UrlEncode(listaEmails) + "&";
                            postData += HttpUtility.UrlEncode("Assunto") + "=" + HttpUtility.UrlEncode(assunto) + "&";
                            postData += HttpUtility.UrlEncode("Interval") + "=" + HttpUtility.UrlEncode(Convert.ToString(this.IntevaloEmail));

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

                            listaRetorno.Invoke((Action<string>)addListaRetorno, "E-mails com sucesso (" + retorno[1] + ") - com erro (" + retorno[2] + ")");
                            statusStrip.Items[3].Text = Convert.ToString(contadorSucesso);
                            statusStrip.Items[5].Text = Convert.ToString(contadorErros);

                            reader.Close();
                            dataStream.Close();
                            response.Close();
                            contador = 0;

                            Thread.Sleep(this.IntevaloLote * 1000);
                        }

                    }
                }
            }

            statusStrip.Items[1].Text = "PARADO";
        }

        /*******************************************************************************************************************************************/

        private void addLista(string linha)
        {
            this.listaEmailsEnviados.Items.Add(linha);
        }

        /*******************************************************************************************************************************************/

        private void addListaRetorno(string linha)
        {
            this.listaRetorno.Items.Add(linha);
        }

        /*******************************************************************************************************************************************/

        private void setNomeText(string texto)
        {
            txtNome.Text = texto;
        }

        /*******************************************************************************************************************************************/

        private void setRemetenteText(string texto)
        {
            txtRementente.Text = texto;
        }

        /*******************************************************************************************************************************************/

        private void setAssuntoText(string texto)
        {
            txtAssunto.Text = texto;
        }

        /*******************************************************************************************************************************************/

        private void btnParar_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnEnvio.Visible = true;
            btnParar.Visible = false;
        }

        /*******************************************************************************************************************************************/
    }
}
