========================================
Source Code (between the arrows)
========================================

🡆fabrics ->        // dude;

    wool fabrics, /* comment <*/
/* ->Comments, man */    cotton fabrics;🡄

========================================
Logged text
========================================

🡆Verbosity set to: High
Language version set to: Describe Basics - v0.6
Describe Transpiler initialized.
Starting a 'File -> AST' operation...
------------------------
Starting a parse operation on file: "C:\Users\Viktor Chernev\Desktop\testing\TestFiles\TestFilesFor06\B_comments3.ds"
Fetched file contents - 104 characters long

Parsing sequence: T(DATA|'fabrics ') T(HYPHEN|'-') T(RIGHT_ARROW|'>        ') T(DATA|'wool fabrics') T(SEPARATOR|', ') T(DATA|'cotton fabrics') T(TERMINATOR|';') T(EOF|'<EOF>') Ok

File parsed successfully
Parser red 104 characters, into 8 tokens.
Those were translated to an AST.
All Files: 1, Succeeded: 1, Failed: 0, Errors: 0🡄

========================================
Produced AST
========================================

{"filename":"C:\\Users\\Viktor Chernev\\Desktop\\testing\\TestFiles\\TestFilesFor06\\B_comments3.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"fabrics","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"wool fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":" "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"cotton fabrics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}