using HarmonyLib;

// ReSharper disable once CheckNamespace
// ReSharper disable once UnusedType.Global
public static class SubverterPatch
{
    public static string Name = "[SMFAEWS] SimpleCommand";
    public static string Description = "Example MOD with one command: smfaews.hello";
    public static Harmony Harm = new("org.ValidHunter.Example.Subverter.Simple.Command");
}