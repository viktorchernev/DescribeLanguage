---
layout: page
title: Describe Compiler CLI - Messages
permalink: /technical/cli/messages/
exclude: true
---
### Options
<span style="color:blue">static bool ONE_BASED_ARG_INDEX</span> - Wether we are using one based index for error reporting. For example, if there is an error in the first cmd argument, if ONE_BASED_ARG_INDEX is true, we will get something like "Error at argument 1". Otherwise we will get "Error at argument 0".

<span style="color:blue">static ConsoleColor INFO_COLOR</span> - The color used for informational text forecolor.

<span style="color:blue">static ConsoleColor TEXT_COLOR</span> - The color used for standard text forecolor.

<span style="color:blue">static ConsoleColor ERROR_COLOR</span> - The color used for error text forecolor.

<span style="color:blue">static ConsoleColor MOREINFO_COLOR</span> - The color used for less important informational text forecolor.

### Presetting
<span style="color:blue">presetConsole()</span> - Set console dimensions and colors.

<span style="color:blue">printLogo3(ConsoleColor logoColor)</span> - Output the ASCII art logo with 3 dashes for shadow to the console.

<span style="color:blue">printLogo3()</span> - Output the ASCII art logo with 3 dashes for shadow to the console, using the default color for text.

<span style="color:blue">printLogo2(ConsoleColor logoColor)</span> - Output the ASCII art logo with 2 dashes for shadow to the console.

<span style="color:blue">printLogo2()</span> - Output the ASCII art logo with 2 dashes for shadow to the console, using the default color for text.

<span style="color:blue">printLogo3Bicolor(ConsoleColor colorA, ConsoleColor colorB)</span> - Output the ASCII art logo with 2 dashes for shadow to the console, in 2 alternating colors.

<span style="color:blue">printLogo3Bicolor()</span> - Output the ASCII art logo with 2 dashes for shadow to the console, in 2 alternating colors, using the default color for text and the default color for info