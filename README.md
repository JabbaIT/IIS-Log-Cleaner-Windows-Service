# IISLogCleanerService
 
## Description

This simple windows service will remove Ageing IIS Log files. 

## INFO 

### Getting Started

## To Install 
To install within CMD prompt run IISLogsCleanerService.exe install

**This will install the service to use System account and startup type is manual.**

## To Uninstall
To uninstall within CMD prompt run IISLogsCleanerService.exe uninstall

## Configuration

The service can be configured via AppSettings.config file 

### AppSettings.config 

* ServiceName - The name of the service
* ServiceDisplayName - The display name for the Service
* ServiceDescription - Provide a description of the service
* DirectoryPath - The Directory of Log Files
* FileExtension - Provide the File extension with Example *.Log
* DaysToKeep - The number of Days of Files to keep.
* RunInterval - Number of hours between each run. 
* AppLogSourceName - The name of source within Application Logs

