# DataField And ProtoId Style

## Rules

- Prefer `[DataField]` without a string name on new code unless compatibility requires a custom serialized key.
- Prefer `ProtoId<T>` or `EntProtoId` over raw prototype ID strings.
- Use `LocId` for stored localization identifiers.
- Keep runtime-only fields free of `[DataField]` unless they are truly serialized config.

## Example Anchor

- `Content.Shared/Anomaly/Components/InnerBodyAnomalyComponent.cs`

## Common Mistakes

- adding raw string prototype IDs to a new component
- serializing temporary runtime caches
- mixing localized literal text and `LocId` in the same pattern
