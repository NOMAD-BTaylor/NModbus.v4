﻿using System.Runtime.CompilerServices;

namespace NModbus.BasicServer.Interfaces
{
    /// <summary>
    /// This is how the server device accesses storage.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDevicePointStorage<T>
    {
        /// <summary>
        /// Reads the specified number of points from the device.
        /// </summary>
        /// <param name="startingAddress"></param>
        /// <param name="numberOfPoints"></param>
        /// <returns></returns>
        T[] ReadPoints(ushort startingAddress, ushort numberOfPoints);

        /// <summary>
        /// Writes the specified number of points from the device.
        /// </summary>
        /// <param name="startingAddress"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        void WritePoints(ushort startingAddress, T[] value);
    }
}
