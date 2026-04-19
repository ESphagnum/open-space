# Content.Shared Agent Notes

Read [../AGENTS.md](../AGENTS.md) first.

For `Content.Shared` work always load:

- `ss14-naming-conventions`
- `ss14-ecs-prototypes`
- `ss14-upstream-maintenance`
- `ss14-ecs-components`
- `ss14-ecs-entities`
- `ss14-ecs-systems`
- `ss14-events`
- `ss14-prediction`
- `ss14-netcode`

Also load:

- `ss14-localization-code` when shared code emits player text or stores `LocId`
- `ss14-graphics-generic-visualizer-appearance` when shared gameplay state drives `Appearance` or `GenericVisualizer`

Shared code owns replicated state, shared events, and prediction-aware logic. Do not add direct client-only or server-only dependencies here.
