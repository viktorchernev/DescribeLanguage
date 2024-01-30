---
layout: page
title: Describe Compiler CLI - Arguments
permalink: /technical/cli/arguments/
exclude: true
---
### IO
<span style="color:blue">```internal static bool readInputArgument(string arg, int argindex)```</span><br>
Read input file or folder<br>
<span style="color:orange">arg</span> - The argument raw text<br>
<span style="color:orange">argindex</span> - The index of the argument (for logging purposes)<br>
<span style="color:orange">returns</span> - True if successful<br>

<span style="color:blue">```internal static bool readInputFileArgument(string arg, int argindex)```</span><br>
Read input file
arg - The argument raw text
argindex - The index of the argument (for logging purposes)
returns - True if successful

<span style="color:blue">```internal static bool readInputFolderArgument(string arg, int argindex)```</span><br>
Read input folder
arg - The argument raw text
argindex - The index of the argument (for logging purposes)
returns - True if successful

<span style="color:blue">```internal static bool readOutputArgument(string arg, int argindex)```</span><br>
Read output file or folder
arg - The argument raw text
argindex - The index of the argument (for logging purposes)
returns - True if successful

<span style="color:blue">```internal static bool readOutputFileArgument(string arg, int argindex)```</span><br>
Read output file
arg - The argument raw text
argindex - The index of the argument (for logging purposes)
returns - True if successful

<span style="color:blue">```internal static bool readOutputFolderArgument(string arg, int argindex)```</span><br>
Read output folder
arg - The argument raw text
argindex - The index of the argument (for logging purposes)
returns - True if successful