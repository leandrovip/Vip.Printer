using Vip.Printer.Enums;

namespace Vip.Printer.Interfaces.Command
{
	internal interface IQrCode
	{
		byte[] Print(string qrData);
		byte[] Print(string qrData, QrCodeSize qrCodeSize);
	}
}