---
layout: page
title: Describe Compiler CLI - Core
permalink: /technical/cli-core/
exclude: true
---
The Describe Compiler CLI is the command line version of the Describe compiler. It is a .Net console application that acts as a wrapper around the Describe Compiler dll and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the [Describe Compiler CLI - Core](/DescribeDocumentation/technical/cli-core) and the [Describe Compiler CLI - Framework](/DescribeDocumentation/technical/cli-framework), that target .Net Core and .Net Framework, respectively. Both apps are more or less identical, but the Core App is the official one, which means that it gets new features implemented first.

The CLI app is relatively small in terms of codebase and relatively simple and straight forward in terms of architecture.
There are 4 distinct modules - Main, Arguments, Messages and Datnik.

#### Main
#### Datnik
#### Messages
#### Arguments
