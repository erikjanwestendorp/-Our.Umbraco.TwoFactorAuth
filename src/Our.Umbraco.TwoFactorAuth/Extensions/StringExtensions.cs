using System.Linq;

namespace Our.Umbraco.TwoFactorAuth.Extensions;

internal static class StringExtensions
{
    public static string ConcatWithSeparator(this string source, string separator, params string[] values)
    {
        return values.Aggregate(source, (current, value) => current + separator + value);
    }
}