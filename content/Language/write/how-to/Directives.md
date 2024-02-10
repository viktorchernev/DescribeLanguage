---
layout: page
title: Describe - Directives
permalink: /language/directives/
exclude: true
---

## Describe - Directives


Directives are commands for the preprocessor that affect the preprocessing or the compilation process for the given source file. In Describe, directives are written as a list, titled "directives". Each directive is an entry in the list. The text of the entry is the name of the directive, and the tag of the entry is the value. The directives list, if present, must be the first list in the source file.

A list of directives and instructions for their use follows:

* <span style="color:blue">**_namespace_** ```namespace <name.ofNamespace>```</span><br>
The namespace directive is related to the dot notation addressing scheme. It is used to set the current namespace for the file, which is then added as a prefix to tag ids (for more info see "Addressing schemes").

* <span style="color:blue">**_verbosity_** ```verbosity <high>```</span><br>
The verbosity directive is used to set the parser verbosity for the file. The values are ```high``` or ```h```, ```medium``` or ```m``` and ```low``` or ```l```.

* <span style="color:blue">**_delimiter-mode_** ```delimiter-mode <mono>```</span><br>
The delimiter-mode directive is used to indicate the delimiter mode of the file. Possible values are ```bi``` or ```2``` or ```mono``` or ```1```. For more information see the article on [delimiter mode](/DescribeDocumentation/language/delimiter-mode).

* <span style="color:orange">**_replace_** ```replace <"text"|"newText">``` *EXPERIMENTAL</span><br>
The replace directive is used to replace all occurances of some text with other text before parsing the source file. The quotes are optional.

* <span style="color:orange">**_regex-replace_** ```regex-replace <"pattern"|"newText">``` *EXPERIMENTAL</span><br>
The regex-replace directive is used to replace all occurances of some regular expression pattern with some text before parsing the source file. The quotes are optional.

<br><br>
<span style="color:blue">In the example below, we have a source file utilizing the verbosity directive to set parser log verbosity to high, and the namespace directive, indicating the current namespace under the dot notation addressing scheme:</span>
```
directives -> 

	verbosity <high>,
	namespace <treeofall.public.unsorted>;



unsorted <rnode> ->

	Amount of sleep needed, by age <amountSleepNeeded>,
	christianity denominations <christianityDenominations>,
	World's Fastest Cars 2023 <fastestCars2023>,
	personality types <personalityTraits>;
```
<br><br>
[**_⮜ Prev_**](/DescribeDocumentation/language/tagging) •
[**_Next ⮞_**](/DescribeDocumentation/language/dot-notation)