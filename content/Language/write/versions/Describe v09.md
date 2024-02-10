---
layout: page
title: Describe Decorators
permalink: /language/v09/
exclude: true
---
Describe version 0.9, codenamed Decorators is the forth test version of the language. It introduced decorators - ```{color|tomato}{bold}```

The GOLD parser grammar is given next<br>
Keep in mind that the precompiler plays a role as well, and this cannot be seen from the grammar file.<br><br>


<span style="color:blue">_Describe 0.9 - Decorators_</span>
```
! Attributes
"Name" = 'D#SCRIBE markup Language'
"Author" = 'DemonOfReason'
"Version" = '0.3'
"About" = 'D#SCRIBE Language'
"Character Mapping" = 'Unicode'
"Case Sensitive" = False
"Start Symbol" = <scripture>

! Comments
Comment Start = '/*'
Comment End = '*/'
Comment Line = '//'
Link Start = '['
Link End = ']'
Decorator Start = '{'
Decorator End = '}'

! Symbols
Hyphen = '-'
LeftArrow = '<'
RightArrow = '>'
Separator = ','
Terminator = ';'
!Star = '*'
!FSlash = '/'
!BSlash = '\'
!LeftSquare = '['
!RightSquare = ']'
!LeftCurl = '{'
!RightCurl = '}'

! Escaped symbols
EscapeHyphen = '\-'
EscapeLeftArrow = '\<'
EscapeRightArrow = '\>'
EscapeLeftSquare = '\['
EscapeRightSquare = '\]'
EscapeLeftCurl = '\{'
EscapeRightCurl = '\}'
EscapeSeparator = '\,'
EscapeTerminator = '\;'
EscapeStar = '\*'
EscapeFSlash = '\/'
EscapeBSlash = '\\'

! Text
{SpecialCharacter} = ['{''}''['']''-''<''>'','';''*''/''\''\-''\<''\>''\,''\;''\*''\/''\\']
{TextCharacter} = {Printable} - {SpecialCharacter}
Text = {TextCharacter}+


! Producer
<producer>
    ::= Hyphen RightArrow

! Tagging
<tag>
    ::= LeftArrow <text> RightArrow

<links>
    ::= Link Link
    | Link <links>

<decorators>
    ::= Decorator Decorator
    | Decorator <decorators>




! Text
<text-chunk>
    ::= Text
    | EscapeHyphen
    | EscapeLeftArrow
    | EscapeRightArrow
    | EscapeSeparator
    | EscapeTerminator
    | EscapeStar
    | EscapeEscape
    | EscapeFSlash
    | EscapeBSlash
    | EscapeLeftSquare
    | EscapeRightSquare
    | EscapeLeftCurl
    | EscapeRightCurl

<text-chunk-list>    
    ::= <text-chunk> <text-chunk>    
     | <text-chunk> <text-chunk-list>

<text>     
    ::= <text-chunk>    
    | <text-chunk-list>
   


! Item
<item>       
    ::= <text>
    | <text> <tag>
    | <text> Link
    | <text> <links>
    | <text> Decorator
    | <text> <decorators>
    
    | <text> <tag> Link
    | <text> Link <tag>
    | <text> <tag> <links>
    | <text> <links> <tag>

    | <text> <tag> Decorator
    | <text> Decorator <tag>
    | <text> <tag> <decorators>
    | <text> <decorators> <tag>
    
    | <text> Link Decorator
    | <text> Decorator Link
    | <text> <links> Decorator
    | <text> Decorator <links>
    
    | <text> Link <decorators>
    | <text> <decorators> Link
    | <text> <links> <decorators>
    | <text> <decorators> <links>

    | <text> <tag> Link Decorator
    | <text> <tag> <links> Decorator
    | <text> <tag> Link <decorators>
    | <text> <tag> <links> <decorators>
    
    | <text> Link <tag> Decorator
    | <text> <links> <tag> Decorator
    | <text> Link <tag> <decorators>
    | <text> <links> <tag> <decorators>

    | <text> Link Decorator <tag>
    | <text> <links> Decorator <tag>
    | <text> Link <decorators> <tag>
    | <text> <links> <decorators> <tag>
    
    | <text> <tag> Decorator Link
    | <text> <tag> Decorator <links>
    | <text> <tag> <decorators> Link
    | <text> <tag> <decorators> <links>

    | <text> Decorator <tag> Link
    | <text> Decorator <tag> <links>
    | <text> <decorators> <tag> Link
    | <text> <decorators> <tag> <links>

    | <text> Decorator Link <tag>
    | <text> Decorator <links> <tag>
    | <text> <decorators> Link <tag>
    | <text> <decorators> <links> <tag>



! Expressions and more
<item-or-expression>    
    ::= <item>    
    | <expression>

<item-or-expression-list>
    ::= <item> Separator <item>
    | <item> Separator <expression>
    | <expression> <item>
    | <expression> <expression>
    
    | <item> Separator <item-or-expression-list>
    | <expression> <item-or-expression-list>

    
    

<expression>     
    ::= <item> <producer> Terminator    
    | <item> <producer> <item-or-expression> Terminator   
    | <item> <producer> <item-or-expression-list> Terminator
    | <item> <producer> <item-or-expression>
    | <item> <producer> <item-or-expression-list>

<expression-list>     
    ::= <expression> <expression>    
    | <expression> <expression-list>

<scripture>     
    ::= <expression>      
    | <expression-list>
```


### Links
[Back](/DescribeDocumentation/language/home)