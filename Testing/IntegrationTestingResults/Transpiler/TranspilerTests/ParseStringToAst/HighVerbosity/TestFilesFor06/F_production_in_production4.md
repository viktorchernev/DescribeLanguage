========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
	
	science ->
		
		math,
		informathics,
		medicine;
    
    water,
    salt;🡄

========================================
Logged text
========================================

🡆Verbosity set to: High
Language version set to: Describe Basics - v0.6
Describe Transpiler initialized.
Starting a 'String -> AST' operation...
------------------------
Starting a parse operation on "Tests.Integration.Transpiler.TestFiles.TestFilesFor06.F_production_in_production4.ds"
Preprocessed source code - 152 characters long

Parsing sequence: T(DATA|'macronutrients ') T(HYPHEN|'-') T(RIGHT_ARROW|'>\r\n\r\n    ') T(DATA|'fiber ') T(HYPHEN|'-') T(RIGHT_ARROW|'>\r\n\r\n        ') T(DATA|'what') T(SEPARATOR|',\r\n        ') T(DATA|'not') T(TERMINATOR|';\r\n\t\r\n\t') T(DATA|'science ') T(HYPHEN|'-') T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t') T(DATA|'math') T(SEPARATOR|',\r\n\t\t') T(DATA|'informathics') T(SEPARATOR|',\r\n\t\t') T(DATA|'medicine') T(TERMINATOR|';\r\n    \r\n    ') T(DATA|'water') T(SEPARATOR|',\r\n    ') T(DATA|'salt') T(TERMINATOR|';') T(EOF|'<EOF>') Ok

Source code parsed successfully
Parse tree unfolded successfully
Done!
------------------------
Parser red 152 characters, into 24 tokens.
Those were translated to an AST.
All Files: 1, Succeeded: 1, Failed: 0, Errors: 0🡄

========================================
Produced AST
========================================

{"filename":"Tests.Integration.Transpiler.TestFiles.TestFilesFor06.F_production_in_production4.ds","nspace":null,"expressions":[{"title":{"tilde":null,"text":{"leafType":"Text","text":"macronutrients","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n    "},"lines":[{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"fiber","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\r\n        "},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"what","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n        "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"not","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":"\r\n\t\r\n\t"}}]},"punctuation":null},{"body":{"title":{"tilde":null,"text":{"leafType":"Text","text":"science","leadingTrivia":"","trailingTrivia":" "},"tag":null,"links":null,"decorators":null},"arrow":{"leafType":"ProductionArrow","text":"->","leadingTrivia":"","trailingTrivia":"\r\n\t\t\r\n\t\t"},"lines":[{"body":{"tilde":null,"text":{"leafType":"Text","text":"math","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"informathics","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n\t\t"}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"medicine","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":"\r\n    \r\n    "}}]},"punctuation":null},{"body":{"tilde":null,"text":{"leafType":"Text","text":"water","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Separator","text":",","leadingTrivia":"","trailingTrivia":"\r\n    "}},{"body":{"tilde":null,"text":{"leafType":"Text","text":"salt","leadingTrivia":"","trailingTrivia":""},"tag":null,"links":null,"decorators":null},"punctuation":{"leafType":"Terminator","text":";","leadingTrivia":"","trailingTrivia":""}}]}],"exception":null}