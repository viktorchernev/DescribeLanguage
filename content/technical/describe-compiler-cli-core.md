---
layout: page
title: Describe Compiler CLI - Core
permalink: /technical/cli-core/
exclude: true
---
The Describe Compiler CLI is the command line version of the Describe compiler. It is a .Net console application that acts as a wrapper around the Describe Compiler dll and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the [Describe Compiler CLI - Core](/DescribeDocumentation/technical/cli-core) and the [Describe Compiler CLI - Framework](/DescribeDocumentation/technical/cli-framework), that target .Net Core and .Net Framework, respectively. Both apps are more or less identical, but the Core App is the official one, which means that it gets new features implemented first.

The CLI app is relatively small in terms of codebase and relatively simple and straight forward in terms of architecture.
There are 5 distinct modules - Program, Main, Arguments, Messages and Datnik.

### Program
C# console applications contain a class called ```Program``` that contains ```static void Main``` method. This is the entry point. This is ```Program.cs```

### Messages
The Messages module - ```FunctionsMessages.cs``` contains methods for setting and changing console propperties and colors and outputting messages, like the help message and the app baner.

### Main
The Main module - ```FunctionsMain.cs``` contains the main functionality of the app.

### Arguments
The Arguments module - ```FunctionsArguments.cs``` contains the methods that are used to read the command line arguments.

### Datnik
The Datnik structure - ```Datnik.cs``` is populated with all the data for the current command that is to be executed.


## Links
* [Program](/DescribeDocumentation/technical/cli-core/program)
* [Messages](/DescribeDocumentation/technical/cli-core/messages)
* [Main](/DescribeDocumentation/technical/cli-core/main)
* [Arguments](/DescribeDocumentation/technical/cli-core/arguments)
* [Datnik](/DescribeDocumentation/technical/cli-core/datnik)