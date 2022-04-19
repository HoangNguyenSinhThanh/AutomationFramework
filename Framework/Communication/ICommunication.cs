using System.Collections.Generic;
using System;
using System.IO;

namespace Framework.Communication
{
    public interface ICommunication : IDisposable
    {
        void Send(string stringToSend);
        string Receive();
    }
}