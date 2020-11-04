﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows;
using System.Windows.Forms;

namespace DataAccess.MailService
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }


        protected void initializeSMTP()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }


        public bool sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(senderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }

                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
                return true;
                
            }
            catch(Exception)
            {
                DialogResult result = MessageBox.Show(
                        "Error al conectarse con el servidor SMTP:\n\n" +
                        "No es posible acceder a soportesistematbc@gmail.com\n" +
                        "Compruebe la configuración de Seguridad de su cuenta de gmail",
                        "ALERTA",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                return false;
            } 
            finally
            {
                mailMessage.Dispose();
            }
        }

    }

}
