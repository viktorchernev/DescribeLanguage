========================================
Source Code (between the arrows)
========================================

🡆fa \-> br\->ics ->

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
│   │   │   └── T(DATA|'fa ')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'> ')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'br')
│   │   ├── text_chunk
│   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_ARROW|'>')
│   │   └── text_chunk
│   │       └── T(DATA|'ics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'wool fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'cotton fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'silk fabrics')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')