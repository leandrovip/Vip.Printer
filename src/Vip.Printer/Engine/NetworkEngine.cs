using System;
using System.Net;
using System.Net.Sockets;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer.Engine
{
    public class NetworkEngine : IEngine
    {
        #region Fields

        private IPEndPoint _endPoint;

        #endregion

        #region Methods

        private void ConfigureEndPoint(string printer)
        {
            var value = printer.Split(':');
            var address = value[0].Trim();
            var port = 0;

            if (value.Length > 1)
                int.TryParse(value[1], out port);
            port = port.Equals(0) ? 9100 : port;

            try
            {
                _endPoint = new IPEndPoint(IPAddress.Parse(address), port);
            }
            catch (Exception)
            {
                throw new ArgumentException($"Endereço de IP ({address}) inválido ou não encontrado");
            }
        }

        public bool Send(string printer, byte[] content)
        {
            ConfigureEndPoint(printer);

            try
            {
                using (var socket = new Socket(_endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp))
                {
                    socket.NoDelay = true;
                    socket.Connect(_endPoint);
                    socket.Send(content);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}