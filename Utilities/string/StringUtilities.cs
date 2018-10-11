using System.Linq;

namespace Utilities
{
    public static class StringUtilities
    {
        /// <summary>
        /// Flattens a string array to a string using a delimitor specified
        /// </summary>
        /// <param name="pStringArray">string array</param>
        /// <param name="delimitor">default to the pipe char '|"</param>
        /// <returns></returns>
        public static string JoinArray(this string[] pStringArray, string delimitor = "|")
        {
            if (pStringArray.IsNull())
                return null;
            else
                return string.Join(delimitor, pStringArray.ToArray());
        }

        /// <summary>
        /// Splits a string into an array
        /// </summary>
        /// <param name="pString">string containing a delimitor, will be tested</param>
        /// <param name="delimitor">default it pipe delimitor "|"</param>
        /// <returns></returns>
        public static string[] SplitToArray(this string pString, char[] delimitor = null)
        {
            var hastohaveone = pString;
            if (delimitor == null)
                delimitor = new char[] { '|' };

            if (pString.IndexOf(hastohaveone) <= 0)
                hastohaveone = string.Concat(pString.Trim(), delimitor[0]);

            return hastohaveone.Split(delimitor);

        }

        /// <summary>
        /// Put a desicription here please
        /// </summary>
        /// <param name="pString"></param>
        /// <param name="pLastXChars"></param>
        /// <returns></returns>
        public static string LastXOfString(this string pString, int pLastXChars)
        {
            if (string.IsNullOrEmpty(pString))
                return pString;

            if (pString.Length < pLastXChars)
                return pString;

            int StartPosition = pString.Length - pLastXChars;

            return pString.Substring(StartPosition);

        }
    }
}
