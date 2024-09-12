using System.ComponentModel;
using MudBlazor;

namespace Codeer.LowCode.Bindings.MudBlazor.Enums
{
    public enum MudVariant
    {
        Outlined,
        Filled,
        Text,
    }

internal static class MudVariantExtension
    {
        public static Variant ToVariant(this MudVariant variant) => variant switch
        {
            MudVariant.Outlined => Variant.Outlined,
            MudVariant.Filled => Variant.Filled,
            MudVariant.Text => Variant.Text,
            _ => throw new InvalidEnumArgumentException()
        };

        public static MudVariant ToMudVariant(this Variant variant) => variant switch
        {
            Variant.Outlined => MudVariant.Outlined,
            Variant.Filled => MudVariant.Filled,
            Variant.Text => MudVariant.Text,
            _ => throw new InvalidEnumArgumentException()
        };
    }
}
