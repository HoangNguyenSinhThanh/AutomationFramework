using System.Collections.Generic;
using System;
using System.IO;
using Framework.Communication;

namespace Framework.Device
{
    public class Arduino : IDevice
    {
        private ICommunication protocol;
        void createProtocol(ICommunication protocol)
        {
            this.protocol = protocol;
        }
        void DeviceAPI();
    }
}