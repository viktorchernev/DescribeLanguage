---
layout: page
title: Unclickable links in production heads
permalink: /DescribeDocumentation/v091/bugs/bug-4
exclude: true
---
_BUG: Unclickable links in production heads_

<span style="color:red">In ```HTML_PARACORD``` - that is the default template set, due to the JavaScript, links in production header does not open when clicked, instead user need to right click and select open in new tab.</span>

<span style="color:green">Removed expression ```t.preventDefault();``` from the javascript code in ```Page.html```</span>
