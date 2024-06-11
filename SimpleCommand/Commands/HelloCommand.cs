using Content.Shared.Administration;
using Robust.Shared.Console;

namespace SimpleCommand.Commands;

[AnyCommand] 
public class SMFAEWSHelloCommand : IConsoleCommand
{
    private const string Art = """
                                  HELLO BRO! THX FOR USING SMFAEWS!
                                       |\---/|
                                       | ,_, |
                                   \_`_/-..----.
                                   ___/ `   ' ,""+ \  sk
                                       (__...'   __\    |`.___.';
                                   (_,...'(_,.`__)/'.....+
                               """;

    public string Command => "smfaews.hello";
    public string Description => "Print Cat-Art in console and chat!";
    public string Help => "HELP!";

    public void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        shell.ExecuteCommand($"""say "{Art}" """);
        shell.WriteLine(Art);
    }
}