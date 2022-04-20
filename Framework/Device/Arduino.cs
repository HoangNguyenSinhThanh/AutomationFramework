using System.Collections.Generic;
using System;
using System.IO;
using Framework.Communication;
using Framework.Command;

namespace Framework.Device
{
    public class Arduino : IDevice
    {
        private ICommunication protocol;
        private bool disposedValue;

        public string Receive()
        {
            throw new NotImplementedException();
        }

        public void Send(ICommand command)
        {
            protocol.Send(command);
        }

        public void Transmit()
        {
            throw new NotImplementedException();
        }

        public void createProtocol(ICommunication protocol)
        {
            this.protocol = protocol;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~Arduino()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}