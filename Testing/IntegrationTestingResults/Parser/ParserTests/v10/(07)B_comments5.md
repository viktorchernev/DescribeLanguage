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
│   │   └── T(TAG|'<xpXWehDW> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> // comment here\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   └── T(TAG|'<TcD3LcoW>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── T(TAG|'<thZBzyNc>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   └── T(TAG|'<dOlQGMJ4>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── T(TAG|'<Ln7Y7Dme>')
│   └── T(TERMINATOR|';// comment last')
└── T(EOF|'<EOF>')