# Changelog

All notable changes to Pure.Diagram.Model.HashCodes are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed
- **`SeriesHash`** renamed to **`DiagramSeriesHash`**, and its constructor
  now accepts `IDiagramSeries` instead of `ISeries`, following the
  corresponding rename in `Pure.Diagram.Model`. This is a breaking change
  for consumers referencing `SeriesHash`/`ISeries` directly.
- Package now targets `Pure.Diagram.Model.Abstractions` `0.1.0-preview.1.0.0`.
- Package validation enabled against baseline `0.1.0-preview.1.0.0`.

## [0.1.0-preview.0.1.0] — 2026-02-09

### Added
- **`DiagramHash`** — deterministic `IDeterminedHash` over an `IDiagram`,
  combining its title, description, type, and series.
- **`DiagramTypeHash`** — deterministic `IDeterminedHash` over an
  `IDiagramType`'s name.
- **`SeriesHash`** — deterministic `IDeterminedHash` over an `ISeries`'
  label and source.
- Multi-targets `net7.0`, `net8.0`, `net9.0`, and `net10.0`, with AOT
  compatibility enabled.
