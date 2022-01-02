using System;
using System.Collections.Generic;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SerilogConsoleAppTemplate
{
    public class EmailStyles
    {
        public const string STYLE_EMAIL_COMMON = "<style>table {border-spacing: 0;border-collapse: collapse;font-family: 'Segoe UI',Helvetica,Arial,sans-serif; font-size:1em;}td, th {border: 1px solid green;text-align: center;padding: 3px;}td {text-align: left;padding: 3px;}</style>";
        public const string STYLE_EMAIL_BODY_COMMON = "<body style=\"font-family: 'Segoe UI',Helvetica,Arial,sans-serif; font-size:1em;\">";
    }

    public class Helper
    {
        private readonly ILogger<Helper> _log;

        public Helper(ILogger<Helper> log, IConfiguration config)
        {
            this._log = log;
            Config.Configuration = config;
        }



        public bool NotifyEmail_ToSupport(string sEmailSubject, string sEmailBodyContent, Dictionary<string, string> sFile)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(Config.SMTP_Server);
                mail.From = new MailAddress("\"" + Config.EmailDisplayName + "\"" + Config.EmailFrom);

                //Email to person
                foreach (var address in Config.EmailTo_ForSupport.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                    mail.To.Add(address);

                if (Config.EmailCC_ForSupport != "")
                {
                    foreach (var address in Config.EmailCC_ForSupport.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                        mail.CC.Add(address);
                }

                if (Config.EmailBCC_ForSupport != "")
                {
                    foreach (var address in Config.EmailBCC_ForSupport.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries))
                        mail.Bcc.Add(address);
                }

                mail.Subject = sEmailSubject;
                //mail.Body = sEmailBody;
                if (Config.EnableHTML == "1")
                    mail.IsBodyHtml = true;
                else
                    mail.IsBodyHtml = false;

                foreach (var sFileAttach in sFile)
                {
                    Attachment attachment;
                    attachment = new System.Net.Mail.Attachment(sFileAttach.Key);
                    attachment.Name = sFileAttach.Value;
                    mail.Attachments.Add(attachment);
                }

                var view = AlternateView.CreateAlternateViewFromString(sEmailBodyContent, null, "text/html");
                mail.AlternateViews.Add(view);

                SmtpServer.Port = Config.SMTP_Server_Port == "" ? 25 : Config.SMTP_Server_Port.ToInt32();
                if (Config.EmailUseNetworkCredential == "1")
                    SmtpServer.Credentials = new System.Net.NetworkCredential(Config.networkCredentialuserName, Config.networkCredentialpassword);

                if (Config.EnableSSL == "1")
                    SmtpServer.EnableSsl = true;
                else
                    SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);


                return true;
            }
            catch (Exception ex)
            {
                _log.LogError(ex.Message);
                return false;
            }
        }
    }
}
