# MirrorTask v1
Run tasks against multiple directories with a single command.

E.g. 
```dotnet run -p .\src\MirrorTask\MirrorTask.csproj filerunner --f Eureka.bat "Hello World.bat"```

By default the list of directories is expected to be stored in:
_C:\Projects\MirrorTask\FileStorage\DefaultDirectories.txt_

Simply put in the absolute paths of all the directories you want to search through when running tasks separated by a new line. There is no need to add quotation marks in this file to handle spaces as they are added automatically. If a directory is not found it will silently move onto the next directory.

If you want to change the name of the directory or file containing the list of directories then simply modify the _FileStorageDirectory_ and _DefaultDirectoriesFileName_ properties in _ApplicationSettings.cs_.

## Common options
### includesubdirectories
By default the application will only search the top level directory when trying to run the task. If you want to include subdirectories add this argument.

Long Name: _--includesubdirectories_ 

Short Name: _-d_

## Tasks
### filerunner
Acccepts a list of space separated file names, including their extensions, that if found in one of the directories should be executed. If a file is not found it will silently move onto the next file. If the file name includes spaces you will need to wrap it in quotation marks.

#### Options

Long name: _--files_ 

Short name: _-f_
