========================================
Source Code (between the arrows)
========================================

🡆fabrics <KvtgGtnv>[] -> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} 

    wool fabrics <rUEqmXfk>[https://www.notube.com/watch?v=hTui12lKus] {decorator},
    cotton fabrics [https://www.notube.com/watch?v=hTui12lKus]{decorator}<wpra8mUV>,
    silk fabrics <VFoIEr0T>[],
    synthetic fabrics <oI5DOuPh>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   ├── T(TAG|'<KvtgGtnv>')
│   │   └── T(LINK|'[] ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> // comment here [https://www.notube.com/watch?v=hTui12lKus] {decorator} \r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── T(TAG|'<rUEqmXfk>')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus] ')
│   │   │   │   └── T(DECORATOR|'{decorator}')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton fabrics ')
│   │   │   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   │   ├── T(DECORATOR|'{decorator}')
│   │   │   │   └── T(TAG|'<wpra8mUV>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk fabrics ')
│   │   │   │   ├── T(TAG|'<VFoIEr0T>')
│   │   │   │   └── T(LINK|'[]')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'synthetic fabrics ')
│   │       └── T(TAG|'<oI5DOuPh>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')