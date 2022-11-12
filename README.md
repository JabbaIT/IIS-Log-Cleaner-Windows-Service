# IISLogCleanerService
 
## Description

This simple windows service will remove Ageing IIS Log files. 

## INFO 

### Getting Started

## To Install 
To install open up a CMD prompt run `IISLogsCleanerService.exe install` within project directory. 

_This will install the service and startup type is manual._

## To Uninstall
To uninstall open up a CMD prompt run `IISLogsCleanerService.exe uninstall` within the project direcotry

## Appsettings.config Settings

The service can be configured via AppSettings.config file 

* ServiceName - _The name of the service_  - **Default: Set to `IISLogCleaner` **
* ServiceDisplayName - _The display name for the Service_ - **Default: Set to `IIS Log Cleaner` **
* ServiceDescription - _Provide a description of the service_ - **Default: Set to `Clean Up Ageing Log Files` **
* DirectoryPath - _The Directory of Log Files_ - **Default: Set to `C:\inetpub\logs\LogFiles` **
* FileExtension - _Provide the File extension - **Default: Set to `*.log` **
* DaysToKeep - _The number of Days of Files to keep._ - **Default: Set to `30` **
* RunInterval - _Number of hours between each run._ - **Default: Set to `24` ** 
* AppLogSourceName - _The name of source within Application Logs_ - **Default: Set to `IISLogCleaner` **

