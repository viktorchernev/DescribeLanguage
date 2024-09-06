========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool {fabrics {{color| red}},
	cotton } fabrics,
	silk fabrics{{decorator}} ,
	synthetic {}{}fabrics {{some text}} ;🡄

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
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_CURL|'{')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(DECORATOR|'{{color| red}}')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_CURL|'} ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics')
│   │   │   │   └── T(DECORATOR|'{{decorator}} ')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_CURL|'{')
│   │       ├── text_chunk
│   │       │   └── T(RIGHT_CURL|'}')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_CURL|'{')
│   │       ├── text_chunk
│   │       │   └── T(RIGHT_CURL|'}')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'fabrics ')
│   │       └── T(DECORATOR|'{{some text}} ')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')