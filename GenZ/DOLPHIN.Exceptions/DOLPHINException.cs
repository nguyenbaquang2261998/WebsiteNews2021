using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Exceptions
{
    public class DOLPHINException : Exception
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DOLPHINException"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        public DOLPHINException(ErrorCode code)
            : base(code.ToString())
        {
            this.HResult = (int)code;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="DOLPHINException"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        public DOLPHINException(ErrorCode code, string message)
            : base(message)
        {
            this.HResult = (int)code;
        }
    }
}
