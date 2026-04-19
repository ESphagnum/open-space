# Content.Server Agent Notes

Read [../AGENTS.md](../AGENTS.md) first.

For `Content.Server` work always load:

- `ss14-naming-conventions`
- `ss14-ecs-prototypes`
- `ss14-upstream-maintenance`
- `ss14-ecs-components`
- `ss14-ecs-entities`
- `ss14-ecs-systems`

Also load:

- `ss14-prediction` and `ss14-netcode` when the server change commits a shared predicted action or handles network messages
- `ss14-localization-code` and `ss14-localization-strings` when player-facing text changes
- `ss14-tests-authoring` when the behavior is risky enough to warrant coverage

Keep authority, persistence, and round rules here. If the player should feel the effect immediately, verify the shared prediction path instead of leaving the feature server-only by accident.
