========================================
Source Code (between the arrows)
========================================

🡆платове ->

	вълнени платове,
	памучни платове,
	копринени платове,
	синтетични платове;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'платове ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'вълнени платове')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'памучни платове')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'копринени платове')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'синтетични платове')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')