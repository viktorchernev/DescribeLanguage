========================================
Source Code (between the arrows)
========================================

🡆->fabrics ->->

	wool fabrics->,
	cotton fabrics,
	silk fabrics,
	synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(HYPHEN|'-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── text_chunk
│   │   │   └── T(HYPHEN|'-')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'>')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(HYPHEN|'-')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'cotton fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'silk fabrics')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')