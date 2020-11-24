﻿using System;
using System.Net.Sockets;

namespace LiteNetwork.Common.Exceptions
{
    /// <summary>
    /// The exception that is thrown when an error occurs during the receive process.
    /// </summary>
    public class LiteReceiverException : LiteNetworkException
    {
        /// <summary>
        /// Gets the connection that thrown the exception.
        /// </summary>
        public ILiteConnection Connection { get; }

        /// <summary>
        /// Gets the receive socket error.
        /// </summary>
        public SocketError SocketError { get; }

        /// <summary>
        /// Creates a new <see cref="LiteReceiverException"/> instance.
        /// </summary>
        /// <param name="connection">Connection that thrown the exception.</param>
        /// <param name="socketError">Socket error.</param>
        /// <param name="innerException">Inner exception.</param>
        public LiteReceiverException(ILiteConnection connection, SocketError socketError, Exception? innerException = null)
            : base($"An error as occured while receiving data for connection with id: '{connection.Id}'.", innerException)
        {
            Connection = connection;
            SocketError = socketError;
        }
    }
}
