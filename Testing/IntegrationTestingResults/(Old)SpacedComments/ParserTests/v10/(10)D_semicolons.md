========================================
Source Code (between the arrows)
========================================

🡆fabrics ->

	wool;; fabrics ->
	cotton ;; fabrics ->
	silk ;;fabrics->
	synthetic ,
	fabrics;;🡄

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
│   │   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'wool')
│   │   └── T(TERMINATOR|';; ')
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'cotton ')
│   │   └── T(TERMINATOR|';; ')
│   ├── expression
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'fabrics ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│   │   ├── item
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'silk ')
│   │   └── T(TERMINATOR|';;')
│   └── expression
│       ├── item
│       │   └── text_chunk
│       │       └── T(DATA|'fabrics')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(PRODUCTION_ARROW|'>\r\n\t')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   └── text_chunk
│       │   │   │       └── T(DATA|'synthetic ')
│       │   │   └── T(SEPARATOR|',\r\n\t')
│       │   └── item
│       │       └── text_chunk
│       │           └── T(DATA|'fabrics')
│       └── T(TERMINATOR|';;')
└── T(EOF|'<EOF>')