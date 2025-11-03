using System;
using System.IO.Ports;

namespace Vip.Printer
{
    public class SerialOptions
    {
        #region Constructors

        public SerialOptions(int baudRate = 9600, int dataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One, Handshake handshake = Handshake.None, int writeTimeoutMs = 5000, int chunkSize = 512, int interChunkDelayMs = 3, bool autoOpenClose = true)
        {
            if (baudRate <= 0) throw new ArgumentOutOfRangeException(nameof(baudRate));

            BaudRate = baudRate;
            DataBits = dataBits;
            Parity = parity;
            StopBits = stopBits;
            Handshake = handshake;
            WriteTimeoutMs = writeTimeoutMs;
            ChunkSize = chunkSize;
            InterChunkDelayMs = interChunkDelayMs;
            AutoOpenClose = autoOpenClose;
        }

        #endregion

        #region Properties

        public int BaudRate { get; }
        public int DataBits { get; }
        public Parity Parity { get; }
        public StopBits StopBits { get; }
        public Handshake Handshake { get; }

        public int WriteTimeoutMs { get; }
        public int ChunkSize { get; }
        public int InterChunkDelayMs { get; }
        public bool AutoOpenClose { get; }

        #endregion
    }
}