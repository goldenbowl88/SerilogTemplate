# SerilogTemplate
A template for serilog. Console, file

Package required.
	Microsoft.Extensions.DependencyInjection
	Microsoft.Extensions.Hosting
	Serilog.Enricers.Environment
	Serilog.Enrichers.Thread
	Serilog.Extensions.Hosting
	Serilog.Settings.Configuration
	Serilog.Sinks Async
	Serilog.Sinks.Console
	Serilog.Sinks.Email
	Serilog.Sinks.File

Configuration neeed to run.
In appsettings.json, these are the basic update needed 
	 "fromEmail" to the indented sender email 
	 "toEmail" to the indented recipent email, seperate by comma
	 "networkCredentialuserName" to your gmail account
	 "networkCredentialpassword" to your gmail password
	 "EmailTo_ForSupport" to the indendted support emails, seperate by comma. 

Gmail Configuration
	 Turn on less secure mode. 
	 https://myaccount.google.com/lesssecureapps?pli=1
 
