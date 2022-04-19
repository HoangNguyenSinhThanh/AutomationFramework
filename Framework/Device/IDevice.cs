using System.Collections.Generic;
using System;
using System.IO;
using Framework.Communication;

namespace Framework.Device
{
    public interface IDevice : IDisposable
    {
        void createProtocol(ICommunication protocol);
        void DeviceAPI();
    }
}