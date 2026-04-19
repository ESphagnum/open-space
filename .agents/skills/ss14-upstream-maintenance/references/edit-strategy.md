# Edit Strategy

## Purpose

Use this file when deciding where and how to implement a change in a fork.

## Rules

- Do not edit `RobustToolbox/` unless the task explicitly calls for engine work.
- Prefer extending content code before changing engine code.
- Keep diffs narrow inside upstream files.
- Preserve existing ordering, spacing, and local style in touched files.
- When creating fork-only behavior, prefer `_OpenSpace` paths that mirror the upstream feature layout.

## Good Patterns

- Add fork-specific systems or resources beside the upstream feature in `_OpenSpace`.
- Extend an existing public system API instead of rewriting the whole feature.
- Add only the fields, prototypes, and locale entries required for the task.

## Bad Patterns

- Moving a large amount of upstream code into fork-only files without need.
- Refactoring unrelated upstream code while fixing a small gameplay issue.
- Editing engine code because it feels cleaner than respecting content boundaries.
