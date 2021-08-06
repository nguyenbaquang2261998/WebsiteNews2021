using System;

namespace DOLPHIN.Helpers
{
    public static class Guard
    {
        /// <summary>
        /// Is Not Null.
        /// </summary>
        /// <param name="value">Value.</param>
        /// <param name="name">Name.</param>
        public static void IsNotNull(object value, string name)
        {
            if (value == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}
