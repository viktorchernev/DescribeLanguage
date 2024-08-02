========================================
Source Code (between the arrows)
========================================

🡆macronutrients ->

    fiber ->

        what,
        not;
	
	science ->
		
		math ->
			algebra,
			geometry;
			
		informathics,
		medicine;
    
    water,
    salt;🡄

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
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   └── text_chunk
│   │   │       │       └── T(DATA|'science ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\r\n\t\t')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   └── expression
│   │   │       │   │       ├── item
│   │   │       │   │       │   └── text_chunk
│   │   │       │   │       │       └── T(DATA|'math ')
│   │   │       │   │       ├── producer
│   │   │       │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   │       │   └── T(RIGHT_ARROW|'>\r\n\t\t\t')
│   │   │       │   │       ├── item_or_expression_list
│   │   │       │   │       │   ├── item_or_expression_part
│   │   │       │   │       │   │   ├── item
│   │   │       │   │       │   │   │   └── text_chunk
│   │   │       │   │       │   │   │       └── T(DATA|'algebra')
│   │   │       │   │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │   │       │   │       │   └── item
│   │   │       │   │       │       └── text_chunk
│   │   │       │   │       │           └── T(DATA|'geometry')
│   │   │       │   │       └── T(TERMINATOR|';\r\n\t\t\t\r\n\t\t')
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(DATA|'informathics')
│   │   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │   │       │   └── item
│   │   │       │       └── text_chunk
│   │   │       │           └── T(DATA|'medicine')
│   │   │       └── T(TERMINATOR|';\r\n    \r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   └── text_chunk
│   │   │   │       └── T(DATA|'water')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   └── item
│   │       └── text_chunk
│   │           └── T(DATA|'salt')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')