# Prototype Manager And Spawn

## Prototype Access

- `Index(protoId)`
- `TryIndex(protoId, out proto)`
- `HasIndex(protoId)`
- `EnumeratePrototypes<T>()`

## Spawn Helpers

- `Spawn(proto, coords)`
- `SpawnAttachedTo(proto, coords)`
- `SpawnAtPosition(proto, coords)`
- `SpawnNextToOrDrop(proto, uid)`

## Rule

If a prototype ID is known at compile time, prefer typed IDs like `ProtoId<T>` or `EntProtoId` instead of raw strings.
