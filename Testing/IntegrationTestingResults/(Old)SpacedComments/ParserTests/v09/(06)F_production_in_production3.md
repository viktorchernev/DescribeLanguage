========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    water,
	fiber ->

        what,
        not;

	somth else;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'macronutrients ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'water')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   └── text_chunk
│   │   │       │       └── T(DATA|'fiber ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(DATA|'what')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       └── text_chunk
│   │   │       │           └── T(DATA|'not')
│   │   │       └── T(TERMINATOR|';\r\n\r\n\t')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'somth else')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')