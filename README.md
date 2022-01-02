# SerilogTemplate
A template for serilog. Console, file

<b>Package required.</b>  <br />
	Microsoft.Extensions.DependencyInjection <br />
	Microsoft.Extensions.Hosting <br />
	Serilog.Enricers.Environment <br />
	Serilog.Enrichers.Thread <br />
	Serilog.Extensions.Hosting <br />
	Serilog.Settings.Configuration <br />
	Serilog.Sinks Async <br />
	Serilog.Sinks.Console <br />
	Serilog.Sinks.Email <br />
	Serilog.Sinks.File <br />

<b>Configuration neeed to run.</b>  <br />
In appsettings.json, these are the basic update needed  <br />
	 "fromEmail" to the indented sender email  <br />
	 "toEmail" to the indented recipent email, seperate by comma <br />
	 "networkCredentialuserName" to your gmail account <br />
	 "networkCredentialpassword" to your gmail password <br />
	 "EmailTo_ForSupport" to the indendted support emails, seperate by comma.  <br />

<b>Gmail Configuration</b>  <br />
	 Turn on less secure mode.  <br />
	 https://myaccount.google.com/lesssecureapps?pli=1 <br />
 
