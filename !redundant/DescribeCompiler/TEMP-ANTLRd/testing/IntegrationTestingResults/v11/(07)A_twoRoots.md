========================================
Source Code (between the arrows)
========================================

🡆macronutrients <Zcm0y9mS> ->

    fiber <ZxMvmqeZ>,
    water <xePTheNI>;

micronutrients <l7qy3zi2>->

    vitamins (ABCDEK) <6Nq8AWj7>,
    minerals (micronutrients) <jG4U9bwg>;🡄

========================================
Parse Tree
========================================

scripture
├── expression_list
│   ├── expression
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'macronutrients ')
│   │   │   ├── text_chunk
│   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'Zcm0y9mS')
│   │   │   └── text_chunk
│   │   │       └── T(RIGHT_ARROW|'> ')
│   │   ├── producer
│   │   │   ├── T(HYPHEN|'-')
│   │   │   └── T(PRODUCTION_ARROW|'>\n\n    ')
│   │   ├── item_or_expression_list
│   │   │   ├── item_or_expression_part
│   │   │   │   ├── item
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'fiber ')
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── text_chunk
│   │   │   │   │   │   └── T(DATA|'ZxMvmqeZ')
│   │   │   │   │   └── text_chunk
│   │   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(SEPARATOR|',\n    ')
│   │   │   └── item
│   │   │       ├── text_chunk
│   │   │       │   └── T(DATA|'water ')
│   │   │       ├── text_chunk
│   │   │       │   └── T(LEFT_ARROW|'<')
│   │   │       ├── text_chunk
│   │   │       │   └── T(DATA|'xePTheNI')
│   │   │       └── text_chunk
│   │   │           └── T(RIGHT_ARROW|'>')
│   │   └── T(TERMINATOR|';\n\n')
│   └── expression
│       ├── item
│       │   ├── text_chunk
│       │   │   └── T(DATA|'micronutrients ')
│       │   ├── text_chunk
│       │   │   └── T(LEFT_ARROW|'<')
│       │   ├── text_chunk
│       │   │   └── T(DATA|'l7qy3zi2')
│       │   └── text_chunk
│       │       └── T(RIGHT_ARROW|'>')
│       ├── producer
│       │   ├── T(HYPHEN|'-')
│       │   └── T(PRODUCTION_ARROW|'>\n\n    ')
│       ├── item_or_expression_list
│       │   ├── item_or_expression_part
│       │   │   ├── item
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(DATA|'vitamins (ABCDEK) ')
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(LEFT_ARROW|'<')
│       │   │   │   ├── text_chunk
│       │   │   │   │   └── T(DATA|'6Nq8AWj7')
│       │   │   │   └── text_chunk
│       │   │   │       └── T(RIGHT_ARROW|'>')
│       │   │   └── T(SEPARATOR|',\n    ')
│       │   └── item
│       │       ├── text_chunk
│       │       │   └── T(DATA|'minerals (micronutrients) ')
│       │       ├── text_chunk
│       │       │   └── T(LEFT_ARROW|'<')
│       │       ├── text_chunk
│       │       │   └── T(DATA|'jG4U9bwg')
│       │       └── text_chunk
│       │           └── T(RIGHT_ARROW|'>')
│       └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')