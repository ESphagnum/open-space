---
name: ss14-ui-bui
description: Implement or review SS14 client UI work. Use when editing `.xaml` or `.xaml.cs` files, bound user interfaces, client windows, style classes, or UI state updates in `Content.Client`, especially when tracing the full shared/server/client chain behind a window, BUI, or predicted interaction.
---

# SS14 UI and BUI

Use established SS14 and Robust UI patterns instead of inventing new ones.

Favor XAML-first layouts, localized text, and predicted-safe client updates. Use the reference files to map the full UI chain before changing code.

## Workflow

1. Open [ui-flow-map.md](references/ui-flow-map.md) first.
- Use it to trace shared state, server handlers, client windows, and localization for the feature.
2. Open [xaml-window-patterns.md](references/xaml-window-patterns.md) for layout conventions.
3. Open [predicted-bui-patterns.md](references/predicted-bui-patterns.md) when the UI action should feel immediate.

2. Find the full UI chain before editing.
- Typical paths include a shared component or BUI state in `Content.Shared`, a client BUI/controller in `Content.Client`, paired `.xaml` and `.xaml.cs` files, and sometimes a server-side system that handles messages.
- Reuse nearby windows and controls in the same feature area before creating a brand-new structure.

3. Prefer XAML-first UI.
- Use XAML for new windows and controls instead of constructing the entire UI in C#.
- Keep `.xaml` and `.xaml.cs` paired.
- Reuse `FancyWindow`, existing style classes, and nearby patterns before editing global stylesheets.
- If you do add styles, keep them narrowly scoped and consistent with nearby SS14 UI.

4. Keep predicted and networked UI honest.
- If the client already has the needed data through networked component state, prefer reading that state instead of duplicating it in extra BUI state when the existing pattern supports it.
- For predicted BUIs, update the UI from component state and `AfterAutoHandleStateEvent` where appropriate.
- Use `SendPredictedMessage` for predicted UI actions instead of non-predicted message sends.
- Remember that predicted client code may re-run many times; avoid server-only popup, audio, or UI calls in predicted shared paths.

5. Localize and stabilize text.
- Localize window titles, labels, buttons, tooltips, and popups.
- Use specific FTL keys; do not leave hardcoded player-facing strings in UI code.

6. Validate the change.
- Build the repo or the relevant projects.
- Run targeted tests when they exist.
- If local runtime verification is not possible, say that the UI still needs an in-game pass.

## Reference Map

- `references/ui-flow-map.md`: full UI chain map, client-only hotspots, and docs caveats for this repo.
- `references/xaml-window-patterns.md`: XAML-first window rules and pairing reminders.
- `references/predicted-bui-patterns.md`: predicted messaging and replicated-state reminders for BUIs.
- `../ss14-client-server-shared/references/shared-and-prediction.md`: shared/client/server ownership for predicted UI flows.
- `../ss14-localization-code/references/localization-in-code.md`: localized UI text usage in client code.
- `../ss14-localization-strings/references/ftl-naming-and-layout.md`: FTL key layout for UI text.

## Useful References

- `references/ui-flow-map.md`
- `references/xaml-window-patterns.md`
- `references/predicted-bui-patterns.md`

## Good File Anchors

- `Content.Client/**/UI/*.xaml`
- `Content.Client/**/UI/*.xaml.cs`
- `Content.Client/**/*BoundUserInterface*.cs`
- `Content.Shared/**/*Component*.cs`
- `Content.Shared/**/*System*.cs`

## Common Pitfalls

- Building a new UI entirely in C# when XAML is the house style.
- Hardcoding player-facing strings instead of localizing them.
- Duplicating networked state in separate BUI state without a good reason.
- Forgetting predicted messaging for interactions that should feel immediate.
