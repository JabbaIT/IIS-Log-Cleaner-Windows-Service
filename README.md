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

* ServiceName - _The name of the service_
* ServiceDisplayName - _The display name for the Service_
* ServiceDescription - _Provide a description of the service_
* DirectoryPath - _The Directory of Log Files_
* FileExtension - _Provide the File extension with Example *.Log_
* DaysToKeep - _The number of Days of Files to keep._
* RunInterval - _Number of hours between each run._ 
* AppLogSourceName - _The name of source within Application Logs_

