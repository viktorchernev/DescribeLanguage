========================================
Source Code (between the arrows)
========================================

🡆fabrics ->> wool fabrics,
	synthetic fabrics;

fabrics->> wool fabrics,
	cotton fabrics;

fabrics ->>wool fabrics,
	silk fabrics;

fabrics->>wool fabrics,
	other fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>> ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   │   └── item
│   │   │       └── text_chunk
│   │   │           └── T(DATA|'synthetic fabrics')
│   │   └── T(TERMINATOR|';\r\n\r\n')
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>> ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   │   └── item
│   │   │       └── text_chunk
│   │   │           └── T(DATA|'cotton fabrics')
│   │   └── T(TERMINATOR|';\r\n\r\n')
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>>')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   │   └── item
│   │   │       └── text_chunk
│   │   │           └── T(DATA|'silk fabrics')
│   │   └── T(TERMINATOR|';\r\n\r\n')
│   └── expression
│       ├── item
│       │   └── text_chunk
│       │       └── T(DATA|'fabrics')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(PRODUCTION_ARROW|'>>')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   └── text_chunk
│       │   │   │       └── T(DATA|'wool fabrics')
│       │   │   └── T(SEPARATOR|',\r\n\t')
│       │   └── item
│       │       └── text_chunk
│       │           └── T(DATA|'other fabrics')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')