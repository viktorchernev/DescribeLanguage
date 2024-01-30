---
layout: page
title: Technical
permalink: /technical/
---
The Describe Compiler is written in C# and consists of few different projects that are related to one another. Below is a list of those projects.

#### Gold Parser Engine
The [Gold Parser Engine](/DescribeDocumentation/technical/gold-parser-engine) is the parser that powers the Describe Compiler. It is a .Net dll library that targets .Net Standard 2.0.

#### Describe Compiler API
The [Describe Compiler API](/DescribeDocumentation/technical/api) is the defacto compiler. It is a .Net dll library that targets .Net Standard 2.0. All the other projects are some kind of fronts for the Describe Compiler API.

#### Describe Compiler CLI
The Describe Compiler CLI is the command line version of the compiler. It is a .Net console application that acts as a wrapper around the dll library and provides a command line interface for the compiler. There are two versions of the Describe Compiler CLI, represented by two different projects - the [Describe Compiler CLI - Core](/DescribeDocumentation/technical/cli-core) and the [Describe Compiler CLI - Framework](/DescribeDocumentation/technical/cli-framework), that target .Net Core and .Net Framework, respectively. Both apps should be more or less identical, but the Core App is the official one, which means tat it gets new features implemented first. The Framework App project is kept just in case that anyone anyone would need a .Net Framework implementation to work on.

#### Describe Compiler AWS
The [Describe Compiler AWS](/DescribeDocumentation/technical/aws-lambda) is Amazon Web Services Lambda function project. It is built for hosting the Describe Compiler as a microservice, in the form of a lambda function.

#### World of lists Tools
The **World of lists Tools** is a toolbox for administration and manipulation of the databases of the worldinlists.net website. It is more of a hackjob of different codes and a sandbox for different ideas. It is command line based. However, as worldinlists.net is currently a proprietary software, this project is not publically available for the moment.

## Links
* [Describe Compiler API](/DescribeDocumentation/technical/api)
* [Describe Compiler CLI - Core](/DescribeDocumentation/technical/cli-core)
* [Describe Compiler CLI - Framework](/DescribeDocumentation/technical/cli-framework)
* [Describe Compiler AWS](/DescribeDocumentation/technical/aws-lambda)
* [Gold Parser Engine](/DescribeDocumentation/technical/gold-parser-engine)