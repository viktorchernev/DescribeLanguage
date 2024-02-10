---
layout: page
title: Grammar v1.0
permalink: /technical/api/grammars/grammar-v10/
exclude: true
---
_Describe 1.0 - Official_

```
! Attributes
"Name" = 'D#SCRIBE markup Language'
"Author" = 'DemonOfReason'
"Version" = '1.0'
"About" = 'D#SCRIBE Language'
"Character Mapping" = 'Unicode'
"Case Sensitive" = False
"Start Symbol" = <scripture>

! Comments
Comment Start = '/*'
Comment End = '*/'
Comment Line = '//'
Link Start = '[['
Link End = ']]'
Decorator Start = '{{'
Decorator End = '}}'

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


! Compound
! Preprocessor needs to doubles right arrow followed by a new line and preceded by hyphen "->\n" - "->>\n"
! Preprocessor needs to escape single right arrows ">" - "\>"
<producer> ::= Hyphen RightArrow RightArrow

! Preprocessor needs to double comma followed by a new line ",\n" - ",,\n"
! Preprocessor needs to escape single comas "," - "\,"
<separator> ::= Separator Separator

! Preprocessor needs to double semicolon followed by a new line ";\n" - ";;\n"
! Preprocessor needs to escape single semicolons ";" - "\;"
<terminator> ::= Terminator Terminator

! Preprocessor needs to escape single left arrows "<" - "\<"
<tagstart> ::= LeftArrow LeftArrow

! Preprocessor needs to escape single right arrows ">" - "\>"
<tagend> ::= RightArrow RightArrow

! Preprocessor needs to escape single left square brackets "[" - "\["
! Preprocessor needs to escape single right square brackets "]" - "\]"
! Preprocessor needs to escape single left curly brackets "{" - "\{"
! Preprocessor needs to escape single right curly brackets "}" - "\}"



! Tagging
<tag> ::= <tagstart> <text> <tagend>

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
    ::= <item> <separator> <item>
    | <item> <separator> <expression>
    | <expression> <item>
    | <expression> <expression>
    
    | <item> <separator> <item-or-expression-list>
    | <expression> <item-or-expression-list>

    
    

<expression>     
    ::= <item> <producer> <terminator>    
    | <item> <producer> <item-or-expression> <terminator>   
    | <item> <producer> <item-or-expression-list> <terminator>
    | <item> <producer> <item-or-expression>
    | <item> <producer> <item-or-expression-list>

<expression-list>     
    ::= <expression> <expression>    
    | <expression> <expression-list>

<scripture>     
    ::= <expression>      
    | <expression-list>

```