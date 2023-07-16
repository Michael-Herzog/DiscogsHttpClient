using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Discogs.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        /// Formats a string to an invariant culture
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="objects">The objects.</param>
        /// <returns></returns>
        [DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string FormatInvariant(this string format, params object[] objects)
            => string.Format(CultureInfo.InvariantCulture, format, objects);

        /// <summary>
        /// Ensure that a string starts with a given char.
        /// </summary>
        /// <param name="value">The target string</param>
        /// <param name="prefix">The char the target string should start with</param>
        /// <returns>The resulting string</returns>
        [DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string EnsureStartsWith(this string value, char prefix)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            return value.StartsWith(prefix) ? value : (prefix + value);
        }

        /// <summary>
        /// Determines whether the string contains at least one non-whitespace char.
        /// </summary>
        [DebuggerStepThrough]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasValue(this string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
    }
}
