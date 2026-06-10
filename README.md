# Pure.Diagram.Model.HashCodes

Deterministic hash code implementations for diagram model abstractions in the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.Model.HashCodes/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model.HashCodes/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.Model.HashCodes/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model.HashCodes/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.Model.HashCodes)](https://www.nuget.org/packages/Pure.Diagram.Model.HashCodes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.Model.HashCodes` provides deterministic, byte-enumerable hash codes for every type in the diagram model abstraction layer. Each type wraps one of the `Pure.Diagram.Model.Abstractions` interfaces and produces a stable byte sequence by prepending a fixed 16-byte type-discriminator prefix before hashing the object's fields.

## API

All types are `sealed record` and implement `IDeterminedHash` (which extends `IEnumerable<byte>`).

| Type | Wraps | Hashed fields |
|---|---|---|
| `DiagramHash` | `IDiagram` | Title, Description, Type, Series |
| `DiagramTypeHash` | `IDiagramType` | Name |
| `DiagramSeriesHash` | `IDiagramSeries` | Label, Source |

## Dependencies

- [`Pure.Diagram.Model.Abstractions`](https://github.com/kudima03/Pure.Diagram.Model.Abstractions) — diagram domain interfaces
- [`Pure.HashCodes`](https://github.com/kudima03/Pure.HashCodes) — deterministic, byte-enumerable hash computation
