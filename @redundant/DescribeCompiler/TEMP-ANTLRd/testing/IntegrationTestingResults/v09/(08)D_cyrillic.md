========================================
Source Code (between the arrows)
========================================

🡆платове <ФЛГмссД> ->

	вълнени платове <ПеП0ТхЗй>[https://www.домейн.com/watch?v=hTui12lKus],
	памучни платове <ПТъЗАфЪа>[https://www.notube.com/watch?v=hTui12lKus],
	копринени платове <5Суак3ИЙ>,
	синтетични платове <ЛКтрт5КН>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'платове ')
│   │   └── T(TAG|'<ФЛГмссД> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'вълнени платове ')
│   │   │   │   ├── T(TAG|'<ПеП0ТхЗй>')
│   │   │   │   └── T(LINK|'[https://www.домейн.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'памучни платове ')
│   │   │   │   ├── T(TAG|'<ПТъЗАфЪа>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'копринени платове ')
│   │   │   │   └── T(TAG|'<5Суак3ИЙ>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'синтетични платове ')
│   │       └── T(TAG|'<ЛКтрт5КН>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')