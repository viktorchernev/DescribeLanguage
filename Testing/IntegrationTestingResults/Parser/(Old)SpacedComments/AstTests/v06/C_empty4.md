========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 

;🡄

========================================
Derived Source Code (between the arrows)
========================================

🡆fabrics -> 

;🡄

========================================
Abstract Syntax Tree
========================================

Scripture : 

    filename - "Tests.Integration.Parser.TestFiles.TestFilesFor06.C_empty4.ds"
    namespace - NULL
    Exception - NULL

    Expression : 
    
        titleItem - Item : 
            
                tilde - NULL
                text - AstLeafNode/Text :  "fabrics"  " "
                tag - NULL
                links - NULL
                decorators - NULL
            
        productionArrow - AstLeafNode/ProductionArrow :  "->"  " \r\n\r\n"
    
        line - ExpressionLine : 
            
                body - NULL
                punctuation - AstLeafNode/Terminator :  ";" 
            
    
========================================
Abstract Syntax Tree (JSON)
========================================

{"filename":"Tests.Integration.Parser.TestFiles.TestFilesFor06.C_empty4.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":" \r\n\r\n"},"lines":[{"body":null,"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}