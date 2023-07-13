﻿namespace NModbus.Interfaces
{
    public class ModbusMessage : IModbusMessage
    {
        public ModbusMessage(byte unitIdentifier, ProtocolDataUnit protocolDataUnit)
        {
            UnitIdentifier = unitIdentifier;
            ProtocolDataUnit = protocolDataUnit ?? throw new ArgumentNullException(nameof(protocolDataUnit));
        }

        public byte UnitIdentifier { get; }

        public ProtocolDataUnit ProtocolDataUnit { get; }
    }
}