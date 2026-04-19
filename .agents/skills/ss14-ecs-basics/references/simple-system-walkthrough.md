# Simple System Walkthrough

## Reading Order

1. Find the component class.
2. Find the system class.
3. Open `Initialize()`.
4. Inspect each `SubscribeLocalEvent(...)`.
5. Follow the handlers and public methods.
6. Check what component state or side effects change afterward.

## Example Anchor

- `Content.Shared/Wieldable/Components/WieldableComponent.cs`
- `Content.Shared/Wieldable/SharedWieldableSystem.cs`

## What To Notice

- dependencies
- subscriptions
- guard clauses
- public action methods
- component mutation and synchronization
