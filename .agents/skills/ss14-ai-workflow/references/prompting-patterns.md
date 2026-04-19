# Prompting Patterns

## Better Prompts

- ask for changes relative to an existing nearby system
- mention prediction, localization, and reuse constraints explicitly
- give the actual file context or surrounding code when the bug is subtle

## Example Shapes

- explain this code and point out likely risks
- write tests for this system, including misuse cases and limits
- refactor this code without changing behavior
- use system X as the pattern and keep the result predicted and reusable

## Rule

“Write the whole feature” is usually worse than “follow this nearby pattern and satisfy these specific SS14 constraints”.
