========================================
Source Code (between the arrows)
========================================

🡆fabrics -> synthetic fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'> ')
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')