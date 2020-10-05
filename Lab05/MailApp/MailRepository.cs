using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Search;
using MimeKit;

namespace MailApp
{
    public class MailRepository
    {
        private string email, password;
        private string imapServer, smtpServer;
        private int imapPort, smtpPort;
        private bool imapSsl, smtpSsl;

        ImapClient imapClient;
        SmtpClient smtpClient;

        IMailFolder inbox;
        List<MimeMessage> messageList;
        ObjectCache cache = MemoryCache.Default;

        public MailRepository(string imapServer, int imapPort, bool imapSsl, string email, string password)
        {
            this.imapServer = imapServer;
            this.imapPort = imapPort;
            this.imapSsl = imapSsl;
            this.email = email;
            this.password = password;

            try
            {
                imapClient = new ImapClient();
                imapClient.Connect(imapServer, imapPort, imapSsl);
                imapClient.AuthenticationMechanisms.Remove("XOAUTH2");
                imapClient.Authenticate(email, password);

                inbox = imapClient.GetFolder(SpecialFolder.Drafts);
                inbox.Open(FolderAccess.ReadOnly);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        public void Disconnect()
        {
            messageList.Clear();
            inbox.Close();
            imapClient.Disconnect(true);
            smtpClient.Disconnect(true);
        }

        public List<MimeMessage> LoadMails(SearchQuery searchQuery, string CacheKey)
        {
            if (cache.Contains(CacheKey)) 
                messageList = (List<MimeMessage>)cache.Get(CacheKey);
            else
            {
                SearchResults results = inbox.Search(SearchOptions.All, searchQuery);
                messageList = new List<MimeMessage>();

                foreach (UniqueId uniqueId in results.UniqueIds)
                {
                    MimeMessage message = inbox.GetMessage(uniqueId);
                    messageList.Add(message);
                }

                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddHours(1.0);
                cache.Add(CacheKey, messageList, cacheItemPolicy);
            }
            return messageList;
        }

        public void ConnectStmpServer(string smtpServer, int smtpPort, bool smtpSsl)
        {
            if (this.smtpServer != smtpServer || this.smtpPort != smtpPort || this.smtpSsl != smtpSsl)
            {
                this.smtpServer = smtpServer;
                this.smtpPort = smtpPort;
                this.smtpSsl = smtpSsl;

                try
                {
                    if (smtpClient != null && smtpClient.IsConnected) smtpClient.Disconnect(true);
                    smtpClient = new SmtpClient();
                    smtpClient.Connect(smtpServer, smtpPort, imapSsl);
                    smtpClient.Authenticate(email, password);
                }
                catch (Exception error) { MessageBox.Show(error.Message); }
            }
        }

        public void SendMail(string subject, string body, string to, string cc = "", string bcc = "")
        {
            MimeMessage message = new MimeMessage();
            message.From.Add(MailboxAddress.Parse(email));
            message.To.Add(MailboxAddress.Parse(to));
            message.Subject = subject;

            TextPart textPart = new TextPart(MimeKit.Text.TextFormat.Html);
            textPart.Text = body;
            message.Body = textPart;

            smtpClient.Send(message);
        }
    }
}
