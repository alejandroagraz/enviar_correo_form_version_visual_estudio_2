using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//using System.Linq;
//using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Net;

namespace enviar_correo_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//==============>> button1_Click <<============

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //SmtpClient server = new SmtpClient("smtp.gmail.com", 587);
                //server.Credentials = new System.Net.NetworkCredential("alejandroagraz@gmail.com", "439665425");

                string servidor = Convert.ToString(textBox1.Text.ToString().Trim());
                int puerto = Convert.ToInt32(textBox2.Text.ToString().Trim());
                string usuario = Convert.ToString(textBox3.Text.ToString().Trim());
                string credencial = Convert.ToString(textBox4.Text.ToString().Trim());
                string destinatario = Convert.ToString(textBox5.Text.ToString().Trim());
                Boolean Ssl = Convert.ToBoolean(textBox7.Text.ToString().Trim());

                MailMessage mnsj = new MailMessage();
                mnsj.To.Add(new MailAddress("joseagraz29@gmail.com"));
                mnsj.CC.Add(new MailAddress(destinatario));
                mnsj.From = new MailAddress("alejandroagraz@gmail.com", "Mensaje de prueba");
                mnsj.Subject = "Mensaje de prueba.";
                mnsj.Body = "Este es el cuerpo del mensaje de prueba desde el boton 1.";

                SmtpClient server = new SmtpClient();
                server.Host = servidor;
                server.Port = puerto;
                server.UseDefaultCredentials = false;
                server.DeliveryMethod = SmtpDeliveryMethod.Network;
                server.Credentials = new System.Net.NetworkCredential(usuario, credencial);
                server.EnableSsl = Ssl;
                server.Send(mnsj);
                MessageBox.Show("Correo enviado exitozamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //==============>> button2_Click <<============

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Web.Mail.MailMessage message = new System.Web.Mail.MailMessage();

            try
            {

                string servidor = Convert.ToString(textBox1.Text.ToString().Trim());
                int puerto = Convert.ToInt32(textBox2.Text.ToString().Trim());
                string usuario = Convert.ToString(textBox3.Text);
                string credencial = Convert.ToString(textBox4.Text);
                string destinatario = Convert.ToString(textBox5.Text.ToString().Trim());
                string remite = Convert.ToString(textBox6.Text.ToString().Trim());
                Boolean Ssl = Convert.ToBoolean(textBox7.Text.ToString().Trim());

                //message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", 1);
                //message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", usuario);
                //message.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", credencial);

                //message.From = remite;
                //message.To = "joseagraz29@gmail.com";
                //message.Cc = destinatario;

                //message.Subject = "Mensaje prueba desde el boton 2.";
                //message.Body = "Cuerpo del correo de prueba.";

                ////System.Web.Mail.MailAttachment attachment = new System.Web.Mail.MailAttachment(PathExcel);
                ////message.Attachments.Add(attachment);

                //System.Web.Mail.SmtpMail.SmtpServer = servidor;
                                
                //System.Web.Mail.SmtpMail.Send(message);
                //MessageBox.Show("Correo enviado exitozamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
