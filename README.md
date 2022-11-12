# IIS Log Cleaner Service
 
### SYNOPSIS

A simple windows service will remove ageing IIS Log files . 

### Description
A Windows Service built using TopShelf package to delete IIS Log files from defined folder location `DirectoryPath`. 
This will remove old log files older than the `DaysToKeep` settings. 

## Getting Started

* Open up the solution within Visual Studio and build the project
* Within the **\IISLogsCleanerService\bin** folder you can install and uninstall compiled Windows Service

## To Install 
To install open up a CMD prompt run `IISLogsCleanerService.exe install` within project directory. 

_This will install the service and startup type is manual._

## To Uninstall
To uninstall open up a CMD prompt run `IISLogsCleanerService.exe uninstall` within the project direcotry

## Appsettings.config Settings

The service can be configured via AppSettings.config file 

* ServiceName - _The name of the service_  - **Default:** Set to `IISLogCleaner`
* ServiceDisplayName - _The display name for the Service_ - **Default:** Set to `IIS Log Cleaner`
* ServiceDescription - _Provide a description of the service_ - **Default:** Set to `Clean Up Ageing Log Files`
* DirectoryPath - _The Directory of Log Files_ - **Default:** Set to `C:\inetpub\logs\LogFiles`
* FileExtension - _Provide the File extension - **Default:** Set to `*.log` 
* DaysToKeep - _The number of Days of Files to keep._ - **Default:** Set to `30`
* RunInterval - _Number of hours between each run._ - **Default:** Set to `24`
* AppLogSourceName - _The name of source within Application Logs_ - **Default:** Set to `IISLogCleaner`

## Limitations
- Within this version, it does not record the files it deletes

