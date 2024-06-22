========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool\;; fabrics ->
	cotton ;\; fabrics ->
	silk \;\;fabrics->
	synthetic ,
	fabrics\;;
;
;
;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── expression
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'wool')
│   │   │   ├── text_chunk
│   │   │   │   └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   ├── text_chunk
│   │   │   │   └── T(SEMICOLON|'; ')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│   │   ├── expression
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(SEMICOLON|';')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_TERMINATOR|'\; ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'fabrics ')
│   │   │   ├── producer
│   │   │   │   ├── T(HYPHEN|'-')
│   │   │   │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│   │   │   ├── expression
│   │   │   │   ├── item
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'silk ')
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'fabrics')
│   │   │   │   ├── producer
│   │   │   │   │   ├── T(HYPHEN|'-')
│   │   │   │   │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│   │   │   │   ├── item_or_expression_list
│   │   │   │   │   ├── item_or_expression_part
│   │   │   │   │   │   ├── item
│   │   │   │   │   │   │   └── text_chunk
│   │   │   │   │   │   │       └── T(DATA|'synthetic ')
│   │   │   │   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   │   │   │   └── item
│   │   │   │   │       ├── text_chunk
│   │   │   │   │       │   └── T(DATA|'fabrics')
│   │   │   │   │       └── text_chunk
│   │   │   │   │           └── T(ESCAPE_TERMINATOR|'\;')
│   │   │   │   └── T(TERMINATOR|';\n')
│   │   │   └── T(TERMINATOR|';\n')
│   │   └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')