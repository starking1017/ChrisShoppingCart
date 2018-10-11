using System;

namespace Utilities
{
    public static class NullUtilities
    {
        public static bool IsNull(this object pObject)
        {
            return pObject == null;
        }

        public static bool IsNotNull(this object pObject)
        {
            return !pObject.IsNull();
        }

        /// <summary>
        /// Empty, Null, or Whitespace is all considered to be a null result
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static bool IsNull(this string pString)
        {
            return string.IsNullOrWhiteSpace(pString);
        }

        public static bool IsNotNull(this string pObject)
        {
            return !pObject.IsNull();
        }

        public static bool IsNull(this Guid pGuid)
        {
            return (pGuid == Guid.Empty);
        }

        public static bool IsNotNull(this Guid pGuid)
        {
            return !pGuid.IsNull();
        }

        public static bool ThrowIfArgumentNull(this object pObject, string pNameOfObject)
        {
            if (pNameOfObject.IsNull())
                throw new ArgumentNullException("ThrowIfNull must have the name of the object");

            if (pObject.IsNull())
                throw new ArgumentNullException(pNameOfObject);

            return true;
        }

        public static bool ThrowIfArgumentNull(this string pObject, string pNameOfObject)
        {
            //first test the string like an object
            (pObject as object).ThrowIfArgumentNull(pNameOfObject);

            //test the object as string - which tests empty or whitespace as well
            if (pObject.IsNull())
                throw new ArgumentNullException(pNameOfObject);

            return true;

        }
    }
}
