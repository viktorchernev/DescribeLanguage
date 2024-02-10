---
layout: page
title: Describe - Dot Notation
permalink: /language/dot-notation/
exclude: true
---
The idea with the "dot notation" scheme is to use namespaces to form complex dot "." separated ids. Instead of writing long ids though, we can use the namespace directive to set the namespace for the current file, and it will then be added as prefix to every id that does not contain a dot or that starts with a dot. This is so because if we have a namespaced id, we need the ability to tell if it is a child namespace we are referring to and needs to be added to the current namespace - so we prefix it with a dot, like ```<.cars.rnode>```, or if it is a full path of its own ```<cars.rnode>``` e.g.

Looking at the example 3 files below, we can observe that:<br>
 • it is customary to name folders after namespaces<br>
 • it is customary that each folder contains one root source file, that is prefixed with at '@' symbol<br>
 • root file contains one root element, which can be tagged with the id rnode, which stands for "root node"<br>
 • namespace directive is used to add to ids<br>

<br><br>
<span style="color:blue">_Example (file-path: ```Public\@public.ds```):_</span>
```
directives ->
	namespace <treeofall.public>;


PUBLIC <rnode> ->

	culture <.culture.rnode>,
	science <.science.rnode>;
```

<br><br>
<span style="color:blue">_file-path: ```Public\Culture\@culture.ds```:_</span>
```
directives ->
	namespace <treeofall.public.culture>;


culture <rnode>->

	arts <gux>,
	recreation,
	cuisine;
```

<br><br>
<span style="color:blue">_file-path: ```Public\Science\@science.ds```:_</span>
```
directives ->
	namespace <treeofall.public.science>;


science <rnode> ->

	math <eqS>,
	informatics,
	physics <SDr>;
```

### Links
[Next](/DescribeDocumentation/language/slash-notation)<br>
[Prev](/DescribeDocumentation/language/directives)
