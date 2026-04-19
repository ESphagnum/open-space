# Engine Boundaries

## Default

- do not touch `RobustToolbox/`
- prefer content-side solutions first
- escalate to engine edits only when the required hook or primitive is genuinely missing

## Good Reasons To Escalate

- missing engine capability with no content-side workaround
- missing serialization, prediction, or rendering primitive

## Bad Reasons To Escalate

- the engine edit looks cleaner than respecting content boundaries
- the task is fork-only gameplay behavior
