﻿
# Number Parser

Console Application for sorting the provided numbers in descending order and storing them in the specified file format.

## Steps to run the application

- Build
	- Using Visual Studio
		- Open the solution in Visual Studio and build the solution.
	- From command line
		- Open command prompt where the solution file exists and execute the below command.

		```
		dotnet build
		```
- Run
	- Go to the following folder in cmd: `NumberParser\bin\Debug\net8.0`
	- Execute the below command.

		```
		NumberParser <Comma-Separated Intergers> <File-Format>

		For example,
		> NumberParser 4,5,1,9,10,58,34,12,0 XML
		```

