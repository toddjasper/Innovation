using System;

namespace Innovation.Voice.Win.UI.Helpers
{
    public static class Extensions
    {
        public static Guid ToGuid(this string input)
        {
            if (input.IsNullOrEmpty()) return Guid.Empty;

            Guid result;
            return Guid.TryParse(input, out result) ? result : Guid.Empty;
        }
    }
}
