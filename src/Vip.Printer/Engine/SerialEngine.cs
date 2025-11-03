using System;
using System.IO.Ports;
using System.Threading;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer.Engine
{
    public sealed class SerialEngine : IEngine, IDisposable
    {
        #region Fields

        private readonly PrinterSettings _settings;
        private SerialPort _port;

        #endregion

        #region Constructors

        public SerialEngine(PrinterSettings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings));
            if (_settings.SerialOptions == null) throw new ArgumentNullException(nameof(settings.SerialOptions));
            if (!settings.SerialOptions.AutoOpenClose) _port = CreateAndOpenPort();
        }

        #endregion

        #region Methods

        public bool Send(string printer, byte[] content)
        {
            try
            {
                if (_settings.SerialOptions.AutoOpenClose)
                {
                    using (var port = CreateAndOpenPort())
                        WriteInChunks(port, content);
                }
                else
                {
                    if (_port == null || !_port.IsOpen)
                    {
                        _port?.Dispose();
                        _port = CreateAndOpenPort();
                    }

                    WriteInChunks(_port, content);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            try { _port?.Dispose(); }
            catch { }
        }

        private SerialPort CreateAndOpenPort()
        {
            var sp = new SerialPort(_settings.PrinterName, _settings.SerialOptions.BaudRate, _settings.SerialOptions.Parity, _settings.SerialOptions.DataBits, _settings.SerialOptions.StopBits)
            {
                Handshake = _settings.SerialOptions.Handshake,
                DtrEnable = false,
                RtsEnable = false,
                WriteTimeout = _settings.SerialOptions.WriteTimeoutMs
            };
            sp.Open();
            Thread.Sleep(10);
            return sp;
        }

        private void WriteInChunks(SerialPort port, byte[] data)
        {
            if (data == null || data.Length == 0) return;

            var offset = 0;
            while (offset < data.Length)
            {
                var count = Math.Min(_settings.SerialOptions.ChunkSize, data.Length - offset);
                port.Write(data, offset, count);
                offset += count;

                if (_settings.SerialOptions.InterChunkDelayMs > 0)
                    Thread.Sleep(_settings.SerialOptions.InterChunkDelayMs);
            }

            if (_settings.SerialOptions.InterChunkDelayMs > 0)
                Thread.Sleep(_settings.SerialOptions.InterChunkDelayMs);
        }

        #endregion
    }
}