========================================
Source Code (between the arrows)
========================================

🡆fabrics<wIcCuax5>->


    wool fabrics<C92Mf6yV>,
    cotton fabrics <TxW3Yetp>,
	
    silk fabrics<08yGbnMX>,
    synthetic fabrics <7MZTHLMY>;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics')
│   │   └── T(TAG|'<wIcCuax5>')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics')
│   │   │   │   └── T(TAG|'<C92Mf6yV>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   └── T(TAG|'<TxW3Yetp>')
│   │   │   └── T(SEPARATOR|',\r\n\t\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics')
│   │   │   │   └── T(TAG|'<08yGbnMX>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── T(TAG|'<7MZTHLMY>')
│   └── T(TERMINATOR|';\r\n')
└── T(EOF|'<EOF>')