# Verification Rules

## Always

- read the generated code
- compare it to nearby repo patterns
- run the smallest meaningful validation
- distrust unexplained architectural changes

## For SS14 Specifically

- verify prediction-sensitive behavior
- verify localization was not skipped
- verify new serialized fields are paired with prototypes
- verify server/client/shared ownership still makes sense

## Rule

Responsibility does not transfer to the model. The merged code is still your code.
