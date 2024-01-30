---
layout: page
title: Describe Compiler CLI - Messages
permalink: /technical/cli/messages/
exclude: true
---
#### Options
<span style="color:blue">static bool ONE_BASED_ARG_INDEX</span> - Wether we are using one based index for error reporting. For example, if there is an error in the first cmd argument, if ONE_BASED_ARG_INDEX is true, we will get something like "Error at argument 1". Otherwise we will get "Error at argument 0".
<span style="color:blue">static ConsoleColor INFO_COLOR</span> - The color used for informational text forecolor
<span style="color:blue">static ConsoleColor TEXT_COLOR</span> - The color used for standard text forecolor
<span style="color:blue">static ConsoleColor ERROR_COLOR</span> - The color used for error text forecolor
<span style="color:blue">static ConsoleColor MOREINFO_COLOR</span> - The color used for less important informational text forecolor