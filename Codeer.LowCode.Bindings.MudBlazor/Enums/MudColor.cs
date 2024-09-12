using System.ComponentModel;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Enums
{
    public enum MudColor
    {
        Default,
        Primary,
        Secondary,
        Tertiary,
        Info,
        Success,
        Warning,
        Error,
        Dark,
        Transparent,
        Inherit,
        Surface
    }

    internal static class MudColorExtension
    {
        public static Color ToColor(this MudColor color) => color switch
        {
            MudColor.Default => Color.Default,
            MudColor.Primary => Color.Primary,
            MudColor.Secondary => Color.Secondary,
            MudColor.Tertiary => Color.Tertiary,
            MudColor.Info => Color.Info,
            MudColor.Success => Color.Success,
            MudColor.Warning => Color.Warning,
            MudColor.Error => Color.Error,
            MudColor.Dark => Color.Dark,
            MudColor.Transparent => Color.Transparent,
            MudColor.Inherit => Color.Inherit,
            MudColor.Surface => Color.Surface,
            _ => throw new InvalidEnumArgumentException()
        };

        public static MudColor ToMudColor(this Color color) => color switch
        {
            Color.Default => MudColor.Default,
            Color.Primary => MudColor.Primary,
            Color.Secondary => MudColor.Secondary,
            Color.Tertiary => MudColor.Tertiary,
            Color.Info => MudColor.Info,
            Color.Success => MudColor.Success,
            Color.Warning => MudColor.Warning,
            Color.Error => MudColor.Error,
            Color.Dark => MudColor.Dark,
            Color.Transparent => MudColor.Transparent,
            Color.Inherit => MudColor.Inherit,
            Color.Surface => MudColor.Surface,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}
