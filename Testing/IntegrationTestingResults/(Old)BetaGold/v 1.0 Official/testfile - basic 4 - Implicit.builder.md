Cannot be parsed without preprocessing by the Describe Compiler preprocessor
========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

    wool fabrics,
    cotton fabrics,
    silk fabrics,
    synthetic fabrics;
🡄

========================================
Preprocessed (between the arrows)
========================================

🡆fabrics ->>

    wool fabrics,,
    cotton fabrics,,
    silk fabrics,,
    synthetic fabrics;;

🡄

========================================
Parse Tree
========================================

+--<scripture> ::= <expression>
|  +--<expression> ::= <item> <producer> <item-or-expression-list> <terminator>
|  |  +--<item> ::= <text>
|  |  |  +--<text> ::= <text-chunk>
|  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  +--fabrics 
|  |  +--<producer> ::= Hyphen RightArrow RightArrow
|  |  |  +---
|  |  |  +-->
|  |  |  +-->
|  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
|  |  |  +--<item> ::= <text>
|  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  +--    wool fabrics
|  |  |  +--<separator> ::= Separator Separator
|  |  |  |  +--,
|  |  |  |  +--,
|  |  |  +--<item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
|  |  |  |  +--<item> ::= <text>
|  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  +--    cotton fabrics
|  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  +--,
|  |  |  |  |  +--,
|  |  |  |  +--<item-or-expression-list> ::= <item> <separator> <item>
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    silk fabrics
|  |  |  |  |  +--<separator> ::= Separator Separator
|  |  |  |  |  |  +--,
|  |  |  |  |  |  +--,
|  |  |  |  |  +--<item> ::= <text>
|  |  |  |  |  |  +--<text> ::= <text-chunk>
|  |  |  |  |  |  |  +--<text-chunk> ::= Text
|  |  |  |  |  |  |  |  +--    synthetic fabrics
|  |  +--<terminator> ::= Terminator Terminator
|  |  |  +--;
|  |  |  +--;


========================================
Parse Actions
========================================

Parse Action      State    Line     Col   Parse Value                       Description                                                               
---------------   -----   -----   -----   -------------------------------   --------------------------------------------------------------------------
Token Read            0       0       0   fabrics                           Token type: Text                                                          
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       0       8   -                                 Token type: Hyphen                                                        
Reduce               20                   (1) ::= fabrics                   <text-chunk> ::= Text                                                     
Reduce               19                   (2) ::= (1)                       <text> ::= <text-chunk>                                                   
Reduce               17                   (3) ::= (2)                       <item> ::= <text>                                                         
Shift                24                                                     The parser shifted to state 24                                            
Token Read           24       0       9   >                                 Token type: RightArrow                                                    
Shift                35                                                     The parser shifted to state 35                                            
Token Read           35       0      10   >                                 Token type: RightArrow                                                    
Shift                64                                                     The parser shifted to state 64                                            
Token Read           64       2       0       wool fabrics                  Token type: Text                                                          
Reduce               25                   (4) ::= - > >                     <producer> ::= Hyphen RightArrow RightArrow                               
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       2      16   ,                                 Token type: Separator                                                     
Reduce               20                   (5) ::=     wool fabrics          <text-chunk> ::= Text                                                     
Reduce               19                   (6) ::= (5)                       <text> ::= <text-chunk>                                                   
Reduce               38                   (7) ::= (6)                       <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       2      17   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       3       0       cotton fabrics                Token type: Text                                                          
Reduce               70                   (8) ::= , ,                       <separator> ::= Separator Separator                                       
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       3      18   ,                                 Token type: Separator                                                     
Reduce               20                   (9) ::=     cotton fabrics        <text-chunk> ::= Text                                                     
Reduce               19                   (10) ::= (9)                      <text> ::= <text-chunk>                                                   
Reduce              101                   (11) ::= (10)                     <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       3      19   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       4       0       silk fabrics                  Token type: Text                                                          
Reduce               70                   (12) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       4      16   ,                                 Token type: Separator                                                     
Reduce               20                   (13) ::=     silk fabrics         <text-chunk> ::= Text                                                     
Reduce               19                   (14) ::= (13)                     <text> ::= <text-chunk>                                                   
Reduce              101                   (15) ::= (14)                     <item> ::= <text>                                                         
Shift                69                                                     The parser shifted to state 69                                            
Token Read           69       4      17   ,                                 Token type: Separator                                                     
Shift                99                                                     The parser shifted to state 99                                            
Token Read           99       5       0       synthetic fabrics             Token type: Text                                                          
Reduce               70                   (16) ::= , ,                      <separator> ::= Separator Separator                                       
Shift                14                                                     The parser shifted to state 14                                            
Token Read           14       5      21   ;                                 Token type: Terminator                                                    
Reduce               20                   (17) ::=     synthetic fabrics    <text-chunk> ::= Text                                                     
Reduce               19                   (18) ::= (17)                     <text> ::= <text-chunk>                                                   
Reduce              101                   (19) ::= (18)                     <item> ::= <text>                                                         
Reduce              102                   (20) ::= (15) (16) (19)           <item-or-expression-list> ::= <item> <separator> <item>                   
Reduce              102                   (21) ::= (11) (12) (20)           <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Reduce               40                   (22) ::= (7) (8) (21)             <item-or-expression-list> ::= <item> <separator> <item-or-expression-list>
Shift                36                                                     The parser shifted to state 36                                            
Token Read           36       5      22   ;                                 Token type: Terminator                                                    
Shift                65                                                     The parser shifted to state 65                                            
Token Read           65       8       0                                     Token type: EOF                                                           
Reduce               72                   (23) ::= ; ;                      <terminator> ::= Terminator Terminator                                    
Reduce               15                   (24) ::= (3) (4) (22) (23)        <expression> ::= <item> <producer> <item-or-expression-list> <terminator> 
Reduce               18                   (25) ::= (24)                     <scripture> ::= <expression>                                              
Accept               18                                                                                                                               


