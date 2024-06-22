Tags are unique identifiers that can be applied to items, so that these items can be referred to from other lists. A tag is just some text, called identifier or id for short, enclosed in angle brackets - aka lesser then `<` and greater then `>` symbols.  
  
To understand how this works, let's look at the example below. We have a list 1) that contains items that are tagged. Those are called placeholders. Next, we have list 2) with it's head item - this is the same item as the one above, because it is denoted with the same tag - only it's text literal is different, but this does not matter. This is called redefinition. Thus, in list one, the placeholder - "Rocky planets <roc>" will be replaced with the redefined item and it's list - list 2). This will happen to every placeholder item tagged with that particular id, and list 2) can also contain tagged placeholder items of its own, of course. This allows for infinite stacking of lists, that might be in different files and in different folders, as is often the case. But we will see this in the next chapter.   
  
Another way of thinking about this is that tags are a way of saying what list goes where - you tag a list somewhere in your code (by tagging the head element) and then copy that head element in other lists, instead of copying the whole list.  
   
Note that tags, decorators and links are written after the text of an entry, and are grouped together - all links - one after another and all the decorators  - one after another. It is not valid to have those mingled together, or having a tag in the middle of the text, for example. It is also not valid to have multiple tags in one item.  
  
Example:  
![tags](https://github.com/viktorchernev/DescribeCompiler/assets/72315339/383a4ebe-0ba9-4377-824a-050d338321e3)
  
[[⮜ Prev|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-decorators]] | [[Next ➤|https://github.com/viktorchernev/DescribeCompiler/wiki/DescribeGrammar-tagging]]