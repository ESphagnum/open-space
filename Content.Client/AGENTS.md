# Content.Client Agent Notes

Read [../AGENTS.md](../AGENTS.md) first.

For `Content.Client` work always load:

- `ss14-naming-conventions`
- `ss14-upstream-maintenance`
- `ss14-prediction`
- `ss14-ui-bui`

Also load:

- `ss14-localization-strings` and `ss14-localization-code` for UI or popup text
- `ss14-netcode` when client work depends on replicated messages or `NetEntity`
- `ss14-graphics-generic-visualizer-appearance` for appearance-driven visual work

Prefer XAML-first UI, client-side presentation, and reading already-networked state before duplicating BUI state.
