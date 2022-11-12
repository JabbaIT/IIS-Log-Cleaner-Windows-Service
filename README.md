# IISLogCleanerService
 
## Description

This simple windows service will remove Ageing IIS Log files. 

## INFO 

### Getting Started


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

