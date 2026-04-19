# Console And Runtime Tools

## Useful Controls

- `~` debug console
- `F3` debug overlay
- `F5` entity spawn window
- `Shift + F4` toggle UI

## Useful Commands

- `list`, `help <command>`
- `vv`, `vvread`, `vvwrite`, `vvinvoke`
- `sudo ...` for server-console-only commands
- `net_graph 1`
- `quickinspect` for paired server/client component inspection

## Prediction Debugging

- test with extra fake lag when possible
- compare server/client VV state for the same entity
- doubled audio or repeated popups usually mean the wrong predicted API was used
