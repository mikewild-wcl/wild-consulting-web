# Wild Consulting Limited

This is the website for Wild Consulting Limited.

## Copyright and License

Website code and content copyright 2019-2026 Wild Consulting Limited.

## Code Repository and build pipeline 

Code can be found at https://github.com/mikewild-wcl/wildconsultingweb.

Build pipeline can be found at https://dev.azure.com/wildconsultingltd.

The pipeline includes steps to create an app_offline.htm file to take the site offline during deployment, and remove it afterwards to bring the site back online.

FTP Server uri and credentials are saved in a variable group in the library named **WildConsultingDeploymentSettings**.

appSettings are overridden by a step in the pipeline. Settings are copied from a variable grpoup named **WildConsultingWebAppSettings**.

## Security

Web site security headers are configured in `Program.cs` using using [NetEscapades.AspNetCore.SecurityHeaders](https://github.com/andrewlock/NetEscapades.AspNetCore.SecurityHeaders). 


