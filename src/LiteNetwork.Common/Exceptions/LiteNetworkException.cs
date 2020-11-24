﻿using System;

namespace LiteNetwork.Common.Exceptions
{
    /// <summary>
    /// Basic LiteNetwork exception.
    /// </summary>
    public class LiteNetworkException : Exception
    {
        /// <summary>
        /// Creates a new <see cref="LiteNetworkException"/> instance.
        /// </summary>
        /// <param name="message">Exception message.</param>
        public LiteNetworkException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Creates a new <see cref="LiteNetworkException"/> instance.
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public LiteNetworkException(string message, Exception? innerException)
            : base(message, innerException)
        {
        }
    }
}
