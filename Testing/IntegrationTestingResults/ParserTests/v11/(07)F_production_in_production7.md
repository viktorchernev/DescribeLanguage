========================================
Source Code (between the arrows)
========================================

🡆macronutrients <ryQ27h6e> ->

	water <hAdLCBLZ>,
    salt <GotVxcPm>,
    fiber <CHcd0L0E> ->

        what <jiSw0LNV>,
        not <TpR3PZdW>;
	
	science <qlMb3HAO> ->
			
		informathics <jn0zFcnW>,
		medicine <JZmdtZj5>,
		
		math <bYBIKVXn> ->
			algebra <nFxP8YKb>,
			geometry <hDNMVYP0>;
;
;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'ryQ27h6e')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'hAdLCBLZ')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'salt ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'GotVxcPm')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n    ')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(LEFT_ARROW|'<')
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'CHcd0L0E')
│   │   │       │   └── text_chunk
│   │   │       │       └── T(RIGHT_ARROW|'> ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'jiSw0LNV')
│   │   │       │   │   │   └── text_chunk
│   │   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(LEFT_ARROW|'<')
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'TpR3PZdW')
│   │   │       │       └── text_chunk
│   │   │       │           └── T(RIGHT_ARROW|'>')
│   │   │       └── T(TERMINATOR|';\r\n\t\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'science ')
│   │       │   ├── text_chunk
│   │       │   │   └── T(LEFT_ARROW|'<')
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'qlMb3HAO')
│   │       │   └── text_chunk
│   │       │       └── T(RIGHT_ARROW|'> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\t\r\n\t\t')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'informathics ')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'jn0zFcnW')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t')
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'medicine ')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'JZmdtZj5')
│   │       │   │   │   └── text_chunk
│   │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │   │   └── T(SEPARATOR|',\r\n\t\t\r\n\t\t')
│   │       │   └── expression
│   │       │       ├── item
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(DATA|'math ')
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(LEFT_ARROW|'<')
│   │       │       │   ├── text_chunk
│   │       │       │   │   └── T(DATA|'bYBIKVXn')
│   │       │       │   └── text_chunk
│   │       │       │       └── T(RIGHT_ARROW|'> ')
│   │       │       ├── producer
│   │       │       │   ├── T(HYPHEN|'-')
│   │       │       │   └── T(PRODUCTION_ARROW|'>\r\n\t\t\t')
│   │       │       ├── item_or_expression_list
│   │       │       │   ├── item_or_expression_part
│   │       │       │   │   ├── item
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(DATA|'algebra ')
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(LEFT_ARROW|'<')
│   │       │       │   │   │   ├── text_chunk
│   │       │       │   │   │   │   └── T(DATA|'nFxP8YKb')
│   │       │       │   │   │   └── text_chunk
│   │       │       │   │   │       └── T(RIGHT_ARROW|'>')
│   │       │       │   │   └── T(SEPARATOR|',\r\n\t\t\t')
│   │       │       │   └── item
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(DATA|'geometry ')
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(LEFT_ARROW|'<')
│   │       │       │       ├── text_chunk
│   │       │       │       │   └── T(DATA|'hDNMVYP0')
│   │       │       │       └── text_chunk
│   │       │       │           └── T(RIGHT_ARROW|'>')
│   │       │       └── T(TERMINATOR|';\n')
│   │       └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')