========================================
Source Code (between the arrows)
========================================

🡆fabrics <xpXWehDW> -> // comment here

    wool fabrics <TcD3LcoW>,
    cotton fabrics <thZBzyNc>,
    silk fabrics <dOlQGMJ4>,
    synthetic fabrics <Ln7Y7Dme>;// comment last🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'xpXWehDW')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> // comment here\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'TcD3LcoW')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'thZBzyNc')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'dOlQGMJ4')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_ARROW|'<')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'Ln7Y7Dme')
│   │       └── text_chunk
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';// comment last')
└── T(EOF|'<EOF>')