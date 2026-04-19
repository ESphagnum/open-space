---
name: ss14-upstream-maintenance
description: Safely maintain a forked SS14 codebase with minimal upstream churn. Use when deciding whether to edit upstream files, when extending behavior in `_OpenSpace`, when preserving path similarity, or when avoiding unnecessary changes to RobustToolbox and offs content.
---

# SS14 Upstream Maintenance

Use this skill whenever a change touches inherited upstream code or may introduce avoidable fork drift.

## Workflow

1. Open `references/edit-strategy.md`.
2. Open `references/engine-boundaries.md` before considering engine or broad upstream edits.
3. Open `references/edit-types.md` for the expected fork-edit patterns.
4. Open `references/path-similarity.md` when adding fork-side files.
5. Open `references/fork-only-content.md` when `_OpenSpace` may be the right home.
2. Prefer the smallest diff that solves the task.
3. Avoid `RobustToolbox/` edits unless the task explicitly requires engine work.
4. Mirror existing folder paths when adding fork-side extensions.

## Reference Map

- `references/edit-strategy.md`
- `references/engine-boundaries.md`
- `references/edit-types.md`
- `references/path-similarity.md`
- `references/fork-only-content.md`
- `../ss14-gameplay-feature/references/open-space-gameplay-map.md`
- `AGENTS.md`
