# Logs VV Breakpoints

## Logs

- use logs to confirm branches, values, and failure reasons
- prefer structured, system-scoped logging over random one-off spam

## View Variables

- inspect both server and client component state
- compare replicated fields when chasing misprediction or sync issues

## Breakpoints

- put them near the suspected failing step
- remember that shared predicted code can hit many times on the client

## Rule

If you need to understand the runtime truth of a component, VV is usually faster than guessing from static code.
