========================================
Source Code (between the arrows)
========================================

🡆fabrics -> ;🡄

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
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')