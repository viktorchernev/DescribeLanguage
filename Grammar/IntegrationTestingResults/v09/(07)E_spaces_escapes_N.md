========================================
Source Code (between the arrows)
========================================

🡆fabric     s 	<TSbLGnNG> ->

	wool   fabrics	 <QWVZ3pp9> ,
	cotton\, fabrics textiles   <75NTfebY>,
    silk\-\>fabrics <Sqs0lm7S>,
    syntic 		fabrics <GcZEI9gy>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabric     s \t')
│   │   └── T(TAG|'<TSbLGnNG> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\n\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool   fabrics\t ')
│   │   │   │   └── T(TAG|'<QWVZ3pp9> ')
│   │   │   └── T(SEPARATOR|',\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'cotton')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_SEPARATOR|'\, ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics textiles   ')
│   │   │   │   └── T(TAG|'<75NTfebY>')
│   │   │   └── T(SEPARATOR|',\n    ')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'silk')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_HYPHEN|'\-')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(ESCAPE_RIGHT_ARROW|'\>')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'fabrics ')
│   │   │   │   └── T(TAG|'<Sqs0lm7S>')
│   │   │   └── T(SEPARATOR|',\n    ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'syntic \t\tfabrics ')
│   │       └── T(TAG|'<GcZEI9gy>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')