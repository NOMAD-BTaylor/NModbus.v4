﻿using System.Net.Sockets;

namespace NModbus.Transports.TcpTransport
{
    internal class SimpleTcpClientContainer : ITcpClientContainer
    {
        public SimpleTcpClientContainer(Stream stream)
        {
            Stream = stream ?? throw new ArgumentNullException(nameof(stream));
        }

        public Stream Stream { get; }

        public ValueTask DisposeAsync()
        {
            return ValueTask.CompletedTask;
        }
    }
}
