using System.Collections.Generic;
using System;
using System.IO;
using Framework.Communication;
using Framework.Command;

namespace Framework.Device
{
    public interface IDevice : IDisposable
    {
        void createProtocol(ICommunication protocol);
        void Send(ICommand command);
        string Receive();
        void Transmit();
    }
}