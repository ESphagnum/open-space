using Content.Shared.Administration;
using Content.Shared.CCVar;
using Content.Shared.GameTicking;
using Robust.Shared.Configuration;
using Robust.Shared.Console;

namespace Content.Server.Administration.Commands;

[AdminCommand(AdminFlags.VarEdit)]
public sealed class SetLobbyMusicCommand : EntitySystem, IConsoleCommand
{
    [Dependency] private readonly IConfigurationManager _cfg = default!;

    public string Command => "setlobbymusic";
    public string Description => Loc.GetString("set-lobby-music-command-description");
    public string Help => Loc.GetString("set-lobby-music-command-help");

    private static bool _alreadyUsed;

    public override void Initialize()
    {
        base.Initialize();
        SubscribeLocalEvent<RoundRestartCleanupEvent>(OnRoundRestart);
    }

    private void OnRoundRestart(RoundRestartCleanupEvent ev)
    {
        _alreadyUsed = false;
    }

    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        if (_alreadyUsed)
        {
            shell.WriteError(Loc.GetString("set-lobby-music-command-already-used"));
            return;
        }

        if (args.Length != 1)
        {
            shell.WriteError(Loc.GetString("set-lobby-music-command-invalid-args"));
            return;
        }

        var newCollection = args[0];
        var current = _cfg.GetCVar(CCVars.LobbyMusicCollection);

        if (current == newCollection)
        {
            shell.WriteError(Loc.GetString("set-lobby-music-command-already-set", ("collection", newCollection)));
            return;
        }

        _cfg.SetCVar(CCVars.LobbyMusicCollection, newCollection);
        _alreadyUsed = true;

        shell.WriteLine(Loc.GetString("set-lobby-music-command-success", ("collection", newCollection)));
    }
}
