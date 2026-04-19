# EntitySystem Functions

## Most Common Helpers

- `HasComp<T>(uid)`
- `Comp<T>(uid)`
- `CompOrNull<T>(uid)`
- `TryComp<T>(uid, out comp)`
- `Resolve(ent, ref ent.Comp)`
- `AddComp<T>(uid)`
- `EnsureComp<T>(uid)`
- `RemComp<T>(uid)`
- `RemCompDeferred<T>(uid)`
- `Del(uid)`
- `QueueDel(uid)`
- `Transform(uid)`
- `MetaData(uid)`
- `Name(uid)`
- `Prototype(uid)`
- `EntityQueryEnumerator<...>()`

## Rules

- prefer `TryComp` for guard clauses
- prefer `Resolve` when your method already takes `Entity<T?>`
- prefer `EnsureComp` over manual existence-then-add patterns
- prefer `QueueDel` inside event handlers
