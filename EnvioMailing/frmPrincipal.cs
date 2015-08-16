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

namespace EnvioMailing
{
    public partial class frmPrincipal : Form
    {
        private int QtdeBlocos = 0;
        private int Intevalo = 0;
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
            // Create a request using a URL that can receive a post. 
            WebRequest request = WebRequest.Create("http://www.wllsistemas.com.br/disparo.php");

            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            //string postData = "NRemetente=Teste de Envio";
            string postData = HttpUtility.UrlEncode("NRemetente") + "="
              + HttpUtility.UrlEncode("Teste de Envio");
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            // Set the ContentType property of the WebRequest.
            request.ContentType = "application/x-www-form-urlencoded";

            request.ContentLength = byteArray.Length;

            Stream dataStream = request.GetRequestStream();

            dataStream.Write(byteArray, 0, byteArray.Length);

            dataStream.Close();

            WebResponse response = request.GetResponse();

            MessageBox.Show(((HttpWebResponse)response).StatusDescription);

            dataStream = response.GetResponseStream();

            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            MessageBox.Show(responseFromServer);

            reader.Close();
            dataStream.Close();
            response.Close();
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
            frmCorpoEmail fCorpoEmail = new frmCorpoEmail();
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
                this.Intevalo = iniFile.ReadInteger("Configuracao", "Intevalo");
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
                MessageBox.Show("Não possível encontrar o arquivo de configuração!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void enviarEmail()
        {
            string nameFile = null;
            string listaEmails = null;
            int contador = 0;

            foreach(string mailing in this.listaMailing)
            {
                if (File.Exists(mailing))
                {
                    nameFile = Path.GetFileNameWithoutExtension(mailing);
                    string[] emails = File.ReadAllLines(@mailing);
                    foreach (string email in emails)
                    {
                        if (contador <= this.QtdeBlocos)
                        {
                            listaEmails += email + "\n";
                            contador++;
                        }
                        else
                        {
                            WebRequest request = WebRequest.Create("http://www.wllsistemas.com.br/disparo.php");
                            request.Method = "POST";
                            request.ContentType = "application/x-www-form-urlencoded";

                            Random random = new Random();
                            int randomNumber = random.Next(0, this.listaAssunto.Count());
                            string postData = HttpUtility.UrlEncode("NRemetente") + "=" + HttpUtility.UrlEncode(nameFile) + "&";
                            postData = HttpUtility.UrlEncode("ERemetente") + "=" + HttpUtility.UrlEncode(nameFile) + "&";
                            postData = HttpUtility.UrlEncode("Conteudo") + "=" + HttpUtility.UrlEncode(this.CorporEmail) + "&";
                            postData = HttpUtility.UrlEncode("Emails") + "=" + HttpUtility.UrlEncode(listaEmails) + "&";
                            postData = HttpUtility.UrlEncode("Assunto") + "=" + HttpUtility.UrlEncode(this.listaAssunto.ElementAt(randomNumber)) + "&";
                            postData = HttpUtility.UrlEncode("Interval") + "=" + HttpUtility.UrlEncode();

                            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                            request.ContentLength = byteArray.Length;

                            Stream dataStream = request.GetRequestStream();
                            dataStream.Write(byteArray, 0, byteArray.Length);
                            dataStream.Close();

                            WebResponse response = request.GetResponse();
                            MessageBox.Show(((HttpWebResponse)response).StatusDescription);

                            dataStream = response.GetResponseStream();
                            StreamReader reader = new StreamReader(dataStream);
                            string responseFromServer = reader.ReadToEnd();
                            MessageBox.Show(responseFromServer);

                            reader.Close();
                            dataStream.Close();
                            response.Close();
                            contador = 0;
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviarEmail();
        }
    }
}
