========================================
Source Code (between the arrows)
========================================

🡆fabric*s ->

	wool fabrics,
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
│   │   │   └── T(DATA|'fabric')
│   │   ├── text_chunk
│   │   │   └── T(STAR|'*')
│   │   └── text_chunk
│   │       └── T(DATA|'s ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool fabrics')
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