========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool [fabrics [[http://someurl.net]],
	cotton ] fabrics,
	silk ][ fabrics[[http://otherurl.net]] ,
	synthetic [] fabrics [[http://url.net]] ;🡄

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
│   │   │   │   │   └── T(LEFT_SQUARE|'[')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(LINK|'[[http://someurl.net]]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_SQUARE|'] ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(RIGHT_SQUARE|']')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_SQUARE|'[ ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics')
│   │   │   │   └── T(LINK|'[[http://otherurl.net]] ')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_SQUARE|'[')
│   │       ├── text_chunk
│   │       │   └── T(RIGHT_SQUARE|'] ')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'fabrics ')
│   │       └── T(LINK|'[[http://url.net]] ')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')