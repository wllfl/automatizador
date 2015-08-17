﻿using System;
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
        private int IntevaloLote = 0;
        private int IntevaloEmail = 0;
        private string Remetente = null;
        private string Url = null;
        private string Diretorio = null;
        private int QtdeAssuntos = 0;
        private int QtdeEmail = 0;
        private string CorporEmail = null;
        List<string> listaMailing = new List<string>();
        List<string> listaAssunto = new List<string>();

        public frmPrincipal()
        {
            InitializeComponent();
            carregarDados();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (this.listaMailing.Count() > 0 && this.listaAssunto.Count() > 0 && this.CorporEmail != "" && this.Url != "")
            {
                //enviarEmail();
                backgroundWorker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("O sistema não possui as configurações mínimas para envio, verifique! \n- Lista de Mailing \n- Lista de Assuntos \n- Conteúdo do E-mail \n- URL PHP de disparo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAssuntos_Click(object sender, EventArgs e)
        {
            frmAssunto fAssunto = new frmAssunto(this);
            fAssunto.Show();
        }

        private void btnCorpoEmail_Click(object sender, EventArgs e)
        {
            frmCorpoEmail fCorpoEmail = new frmCorpoEmail(this);
            fCorpoEmail.Show();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            frmConfiguracao fConfiguracao = new frmConfiguracao(this);
            fConfiguracao.Show();
        }

        public void carregarDados()
        {
            if (File.Exists("./Config.ini"))
            {
                this.QtdeEmail = 0;
                this.QtdeAssuntos = 0;
                this.listaAssunto.Clear();
                this.listaMailing.Clear();

                var iniFile = new IniFile("./Config.ini");

                this.QtdeBlocos = iniFile.ReadInteger("Configuracao", "QtdeEmailBloco");
                this.IntevaloLote = iniFile.ReadInteger("Configuracao", "IntevaloLote");
                this.IntevaloEmail = iniFile.ReadInteger("Configuracao", "IntevaloEmail");
                this.Remetente = iniFile.ReadString("Configuracao", "NomeRemetente");
                this.Url = iniFile.ReadString("Configuracao", "URL");
                this.Diretorio = iniFile.ReadString("Configuracao", "Diretorio");
                this.CorporEmail = iniFile.ReadString("Email", "Texto");

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

                for (int i = 0; i < dgvHost.Rows.Count; i++)
                {
                    dgvHost.Rows.RemoveAt(i);
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

        private void enviarEmail()
        {
            string nameFile = null;
            string listaEmails = null;
            int contador = 0;
            int contadorGeral = 0;
            int contadorErros = 0;
            int contadorSucesso = 0;
            int totalLinhas = 0;

            statusStrip.Items[1].Text = "EXECUTANDO";

            foreach(string mailing in this.listaMailing)
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
                            listaEmailsEnviados.Items.Add(email);
                            contador++;
                            contadorGeral++;
                        }
            
                        if(contador == this.QtdeBlocos || contadorGeral == totalLinhas)
                        {
                            WebRequest request = WebRequest.Create("http://www.wllsistemas.com.br/disparo.php");
                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";

                            Random random = new Random();
                            int randomNumber = random.Next(0, this.listaAssunto.Count());
                            string assunto = this.listaAssunto.ElementAt(randomNumber);

                            txtNome.Text = this.Remetente;
                            txtRementente.Text = nameFile;
                            txtAssunto.Text = assunto;

                            string postData = HttpUtility.UrlEncode("NRemetente") + "=" + HttpUtility.UrlEncode(this.Remetente) + "&";
                            postData += HttpUtility.UrlEncode("ERemetente") + "=" + HttpUtility.UrlEncode(nameFile) + "&";
                            postData += HttpUtility.UrlEncode("Conteudo") + "=" + HttpUtility.UrlEncode(this.CorporEmail) + "&";
                            postData += HttpUtility.UrlEncode("Emails") + "=" + HttpUtility.UrlEncode(listaEmails) + "&";
                            postData += HttpUtility.UrlEncode("Assunto") + "=" + HttpUtility.UrlEncode(assunto) + "&";
                            postData += HttpUtility.UrlEncode("Interval") + "=" + HttpUtility.UrlEncode(Convert.ToString(this.IntevaloEmail));

                            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                            request.ContentLength = byteArray.Length;

                            Stream dataStream = request.GetRequestStream();
                            dataStream.Write(byteArray, 0, byteArray.Length);
                            dataStream.Close();

                            WebResponse response = request.GetResponse();
                            //MessageBox.Show(((HttpWebResponse)response).StatusDescription);

                            dataStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(dataStream);
                            string responseFromServer = reader.ReadToEnd();
                            
                            string[] retorno = responseFromServer.Split('#');
                            contadorSucesso += Convert.ToInt32(retorno[1]);
                            contadorErros += Convert.ToInt32(retorno[2]);

                            listaRetorno.Items.Add("E-mails com sucesso ("+retorno[1]+") - com erro ("+retorno[2]+")");
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

        private void button1_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            string nameFile = null;
            string listaEmails = null;
            int contador = 0;
            int contadorGeral = 0;
            int contadorErros = 0;
            int contadorSucesso = 0;
            int totalLinhas = 0;

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
                            WebRequest request = WebRequest.Create(this.Url);
                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";

                            Random random = new Random();
                            int randomNumber = random.Next(0, this.listaAssunto.Count());
                            string assunto = this.listaAssunto.ElementAt(randomNumber);

                            txtNome.Invoke((Action<string>)setNomeText, this.Remetente);
                            txtRementente.Invoke((Action<string>)setRemetenteText, nameFile);
                            txtAssunto.Invoke((Action<string>)setAssuntoText, assunto);

                            string postData = HttpUtility.UrlEncode("NRemetente") + "=" + HttpUtility.UrlEncode(this.Remetente) + "&";
                            postData += HttpUtility.UrlEncode("ERemetente") + "=" + HttpUtility.UrlEncode(nameFile) + "&";
                            postData += HttpUtility.UrlEncode("Conteudo") + "=" + HttpUtility.UrlEncode(this.CorporEmail) + "&";
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

        private void addLista(string linha)
        {
            this.listaEmailsEnviados.Items.Add(linha);
        }

        private void addListaRetorno(string linha)
        {
            this.listaRetorno.Items.Add(linha);
        }


        private void setNomeText(string texto)
        {
            txtNome.Text = texto;
        }

        private void setRemetenteText(string texto)
        {
            txtRementente.Text = texto;
        }

        private void setAssuntoText(string texto)
        {
            txtAssunto.Text = texto;
        }

        private void toolStripStatusLabel6_Click(object sender, EventArgs e)
        {

        }

    }
}
