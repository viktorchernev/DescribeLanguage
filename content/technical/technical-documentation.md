---
layout: page
title: Technical
permalink: /technical/
---
The Describe Compiler is written in C# and consists of few different projects that are related to one another.

* The [Gold Parser Engine](/DescribeDocumentation/gold-parser) is the parser that powers the Describe Compiler. It is also .Net dll library.
* The [API](/DescribeDocumentation/api) is the defacto compiler. It is a .Net dll library that targets .Net Standard.
* The CLI is the command line version of the compiler. It is a .Net console application that acts as a wrapper around the dll library and provides a command line interface. There are two versions of the CLI - the [CLI Core](/DescribeDocumentation/cli-core) and the [CLI Framework](/DescribeDocumentation/cli-framework), that target .Net Core and .Net Framework, respectively. Both apps should be identical, but the [CLI Core](/DescribeDocumentation/cli-core) is the official one and the [CLI Framework](/DescribeDocumentation/cli-framework) is kept should anyone need a .Net Framework based project to modify.
* The [AWS](/DescribeDocumentation/aws-lambda) is Amazon Web Services Lambda function project. It is for hosting the Describe Compiler as a microservice, in the form of a lambda function.

## links
* [Describe Compiler API](/DescribeDocumentation/api)
* [Describe Compiler CLI - Core](/DescribeDocumentation/cli-core)
* [Describe Compiler CLI - Framework](/DescribeDocumentation/cli-framework)
* [Describe Compiler AWS](/DescribeDocumentation/aws-lambda)
* [Gold Parser Engine](/DescribeDocumentation/gold-parser-engine)