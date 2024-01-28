---
layout: page
title: Technical
permalink: /technical/
---
The Describe Compiler is written in C# and consists of few different projects that are related to one another.

### Gold Parser Engine
The [Gold Parser Engine](/DescribeDocumentation/gold-parser) is the parser that powers the Describe Compiler. It is a .Net dll library.

### Describe Compiler API
The [Describe Compiler API](/DescribeDocumentation/api) is the defacto compiler. It is a .Net dll library that targets .Net Standard 2.0. All the other projects are some kind of fronts for the Describe Compiler API.

### Describe Compiler CLI
The Describe Compiler CLI is the command line version of the compiler. It is a .Net console application that acts as a wrapper around the dll library and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the [Describe Compiler CLI - Core](/DescribeDocumentation/cli-core) and the [Describe Compiler CLI - Framework](/DescribeDocumentation/cli-framework), that target .Net Core and .Net Framework, respectively. Both apps should be more or less identical, but the Core App is the official one, which means tat it gets new features implemented first. The Framework App project is kept just in case that anyone anyone would need a .Net Framework implementation to work on.

### Describe Compiler AWS
The [Describe Compiler AWS](/DescribeDocumentation/aws-lambda) is Amazon Web Services Lambda function project. It is built for hosting the Describe Compiler as a microservice, in the form of a lambda function.

## links
* [Describe Compiler API](/DescribeDocumentation/api)
* [Describe Compiler CLI - Core](/DescribeDocumentation/cli-core)
* [Describe Compiler CLI - Framework](/DescribeDocumentation/cli-framework)
* [Describe Compiler AWS](/DescribeDocumentation/aws-lambda)
* [Gold Parser Engine](/DescribeDocumentation/gold-parser-engine)