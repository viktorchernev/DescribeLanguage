---
layout: page
title: Grammar v0.6
permalink: /testing/grammar-v06/
exclude: true
---
_Describe Basics (v0.6)_

<span style="color:green">basic functionality</span>
<span style="color:blue">```basic 1.ds```</span> - Some very simple list<br>
<span style="color:blue">```basic 2.ds```</span> - Some very simple list with 1 entry<br>
<span style="color:blue">```basic 3.ds```</span> - Some very simple list with 1 entry on the same line (in-lined production)<br>
<span style="color:blue">```basic 4.ds```</span>  - Some very simple list ending with a new line character<br>


comments - testing how comments work 
comments 1.ds - Some very simple list with a line comment ("//") 
comments 2.ds - Some very simple list with a line comment ("//") and a commented out entry - delimited comment (/* ... */)
comments 3.ds - Some very simple list with a line comment ("//") and a commented out logic - multiple delimited comments (/* ... */)
comments 4.ds - Some very simple list with 2 line comments ("//"), ending with a comment on a new line (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though). 
comments 5.ds - Some very simple list with 2 line comments ("//"), ending with a comment on the same line (there is an issue with the GOLD parsed engine that results in a runaway group if source file ends with a comment. We handle it during preprocessing though).

double characters - testing if characters that are a start of a multi-character terminal are correctly handled 
double characters 1.ds - Some very simple list containing a hyphen "-", as it is a start character of a producer "->" 
double characters 2.ds - Some very simple list containing a forward slash "/", as it is a start character of a comment "//" or "/*" 
double characters 3.ds  Some very simple list containing a back slash "\", as it is a start character of escape sequences "\,"

empty - the idea here is to test empty productions (without entries)
empty 1.ds - Simple empty production. 
empty 2.ds - Simple empty production, no spaces. 
empty 3.ds - Simple empty production, with spaces. 
empty 4.ds - Simple empty production, with spaces and new lines.

escaped double characters - testing escape sequences 
escaped double characters 1.ds - Testing escape sequence - escaped dash. 
escaped double characters 2.ds - Testing escape sequence - escaped forward slash. 
escaped double characters 3.ds - Testing escape sequence - escaped backward slash (escape escape). 
spaces and escape sequences N.ds - Testing a combination of spaces, new lines and escape sequences. Linux style new lines ("\n"). 
spaces and escape sequences RN.ds - Testing a combination of spaces, new lines and escape sequences. Windows style new lines ("\r\n").

productions 
production in production 1.ds - Production containing a child production as first child. 
production in production 2.ds - Production containing a child production as last child. 
production in production 3.ds - Production containing a child production as middle child. 
production in production 4.ds - Production containing 2 child productions as first and second child. 
production in production 5.ds - Production containing 2 child productions as last and next to last child. 
production in production 6.ds - Production containing a child production containing a child production. 
production in production 7.ds - Production containing a child production containing a child production as last.

other 
2 root nodes.ds - Two simple lists in one file 
cyrillic.ds - Some very simple list in Cyrillic. This is for testing the pre-processor, as the GOLD Parser can't parse Cyrillic.