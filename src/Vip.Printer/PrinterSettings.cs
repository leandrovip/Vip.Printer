using System.IO.Ports;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.Interfaces.Engine;

namespace Vip.Printer
{
    public sealed class PrinterSettings
    {
        #region Properties

        public string PrinterName { get; }
        public PrinterType PrinterType { get; }
        public ProtocolType Protocol { get; }
        public Encoding Encoding { get; }
        public SerialOptions SerialOptions { get; }
        public IEngine Engine { get; }
        public int ColsNormal { get; }
        public int ColsCondensed { get; }
        public int ColsExpanded { get; }

        #endregion

        #region Constructors

        private PrinterSettings(string printerName, PrinterType printerType, ProtocolType protocol, Encoding encoding, SerialOptions serialOptions, IEngine engine, int colsNormal, int colsCondensed, int colsExpanded)
        {
            PrinterName = string.IsNullOrWhiteSpace(printerName) ? "temp.prn" : printerName.Trim();
            PrinterType = printerType;
            Protocol = protocol;
            Encoding = encoding;
            SerialOptions = serialOptions;
            Engine = engine;
            ColsNormal = colsNormal;
            ColsCondensed = colsCondensed;
            ColsExpanded = colsExpanded;
        }

        #endregion

        #region Methods Statics

        public static PrinterSettingsBuilder Create() => new PrinterSettingsBuilder();

        public static PrinterSettings FromLegacy(string printerName, PrinterType type, int colsNormal, int colsCondensed, int colsExpanded, Encoding encoding, ProtocolType protocol)
        {
            return Create()
                .WithPrinterName(printerName)
                .WithPrinterType(type)
                .WithColumns(colsNormal, colsCondensed, colsExpanded)
                .WithEncoding(encoding)
                .WithProtocol(protocol)
                .Build();
        }

        #endregion

        #region Builder

        public sealed class PrinterSettingsBuilder
        {
            #region Fields

            private string _printerName;
            private PrinterType _printerType = PrinterType.Epson;
            private ProtocolType _protocol = ProtocolType.Raw;
            private Encoding _encoding;
            private SerialOptions _serialOptions;
            private IEngine _engine;
            private int _colsNormal;
            private int _colsCondensed;
            private int _colsExpanded;

            #endregion

            #region Constructors

            public PrinterSettings Build()
            {
                return new PrinterSettings(_printerName, _printerType, _protocol, _encoding, _serialOptions, _engine, _colsNormal, _colsCondensed, _colsExpanded);
            }

            #endregion

            #region Methods

            public PrinterSettingsBuilder WithPrinterName(string printerName)
            {
                _printerName = printerName;
                return this;
            }

            public PrinterSettingsBuilder WithPrinterType(PrinterType type)
            {
                _printerType = type;
                return this;
            }

            public PrinterSettingsBuilder WithProtocol(ProtocolType protocol)
            {
                _protocol = protocol;
                return this;
            }

            public PrinterSettingsBuilder WithEncoding(Encoding encoding)
            {
                _encoding = encoding;
                return this;
            }

            public PrinterSettingsBuilder WithSerialOptions(int baudeRate, int dataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One, Handshake handshake = Handshake.None)
            {
                _serialOptions = new SerialOptions(baudeRate, dataBits, parity, stopBits, handshake);
                return this;
            }

            public PrinterSettingsBuilder WithEngine(IEngine engine)
            {
                _engine = engine;
                return this;
            }

            public PrinterSettingsBuilder WithColumns(int normal, int condensed, int expanded)
            {
                _colsNormal = normal;
                _colsCondensed = condensed;
                _colsExpanded = expanded;
                return this;
            }

            #endregion
        }

        #endregion
    }
}