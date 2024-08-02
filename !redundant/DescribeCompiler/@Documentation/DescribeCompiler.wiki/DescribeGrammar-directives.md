Directives are commands for the compiler that affect the compilation process for the given source file. In Describe, directives are written as a list, titled "directives". Each directive is an entry in the list. The text of the entry is the name of the directive, and the tag of the entry is the value. The directives list, if present, must be the first list in the source file.  

A list of directives and instructions for their use follows:  

`namespace` - The namespace directive is related to the dot notation addressing scheme. It is used to set the current namespace, which is then added as a prefix to tag ids (for more info see "Addressing schemes").  
  
In the example below, we have a source file utilizing the verbosity directive to set parser log verbosity to high, and the namespace directive, indicating the current namespace under the dot notation addressing scheme.  
  
Example:  
![directives](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/f8b918ec-93af-4475-84f1-e7d9110e2cf1)

  
[[⮜ Prev|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-tagging]] | [[Next ➤|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-dot-notation]]