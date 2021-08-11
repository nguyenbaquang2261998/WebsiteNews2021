using System;
using System.Collections.Generic;
using System.Text;

namespace DOLPHIN.Exceptions
{
    public class DolphinException : Exception
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DolphinException"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        public DolphinException(ErrorCode code)
            : base(code.ToString())
        {
            this.HResult = (int)code;
        }

        /// <summary>
        /// Initialises a new instance of the <see cref="DOLPHINException"/> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="message">message.</param>
        public DolphinException(ErrorCode code, string message)
            : base(message)
        {
            this.HResult = (int)code;
        }
    }
}
