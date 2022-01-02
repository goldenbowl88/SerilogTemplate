using Microsoft.Extensions.Configuration;

namespace SerilogConsoleAppTemplate
{
    public static class Config
    {
        public static IConfiguration Configuration;
        public static string ProductionMode { get { return Configuration.GetValue<string>("ProductionMode"); } }
           
        public static string SMTP_Server { get { return Configuration.GetValue<string>("Serilog:WriteTo:0:Args:configure:2:Args:mailServer"); } }
        public static string SMTP_Server_Port { get { return Configuration.GetValue<string>("Serilog:WriteTo:0:Args:configure:2:Args:smtpPort"); } }
        public static string EmailTo_ForSupport { get { return Configuration.GetValue<string>("EmailTo_ForSupport"); } }
        public static string EmailCC_ForSupport { get { return Configuration.GetValue<string>("EmailCC_ForSupport"); } }
        public static string EmailBCC_ForSupport { get { return Configuration.GetValue<string>("EmailBCC_ForSupport"); } }
        public static string EmailFrom { get { return Configuration.GetValue<string>("EmailFrom"); } }
        public static string EmailSubject { get { return Configuration.GetValue<string>("EmailSubject"); } }
        public static string EmailSubject_ForSupport { get { return Configuration.GetValue<string>("EmailSubject_ForSupport"); } }
        public static string EmailSubject_Alert_ForSupport { get { return Configuration.GetValue<string>("EmailSubject_Alert_ForSupport"); } }
        public static string EmailDisplayName { get { return Configuration.GetValue<string>("EmailDisplayName"); } }
        public static string EnableHTML { get { return Configuration.GetValue<string>("EnableHTML"); } }
        public static string EnableSSL { get { return Configuration.GetValue<string>("EnableSSL"); } }
        public static string EmailUseNetworkCredential { get { return Configuration.GetValue<string>("EmailUseNetworkCredential"); } }
        public static string networkCredentialuserName { get { return Configuration.GetValue<string>("Serilog:WriteTo:0:Args:configure:2:Args:networkCredentialuserName"); } }
        public static string networkCredentialpassword { get { return Configuration.GetValue<string>("Serilog:WriteTo:0:Args:configure:2:Args:networkCredentialpassword"); } }

    }
}
