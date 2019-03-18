using System.Collections.Generic;
using System.Text;
using Vip.Printer.Enums;
using Vip.Printer.Extensions;
using Vip.Printer.Interfaces.Command;

namespace Vip.Printer.EscBemaCommands
{
	internal class QrCode : IQrCode
	{
		private static byte[] Size(QrCodeSize size)
		{
			switch (size)
			{
				case QrCodeSize.Size1:
					return new byte[] {1};
				case QrCodeSize.Size2:
					return new byte[] {2};
				default:
					return new byte[] {0};
			}
		}

		private static IEnumerable<byte> StoreQr(string qrData, QrCodeSize size)
		{
			var length = qrData.Length;
			var b = (byte) (length % 256);
			var b2 = (byte) (length / 256);

			return new byte[] {29, 107, 81}
				.AddBytes(Size(size))
				.AddBytes(new byte[] {8, 0, 1})
				.AddBytes(new[] {b})
				.AddBytes(new[] {b2})
				.AddBytes(new byte[] {13, 10});
		}

		public byte[] Print(string qrData)
		{
			return Print(qrData, QrCodeSize.Size0);
		}

		public byte[] Print(string qrData, QrCodeSize qrCodeSize)
		{
			var list = new List<byte>();
			list.AddRange(StoreQr(qrData, qrCodeSize));
			list.AddRange(Encoding.UTF8.GetBytes(qrData));
			return list.ToArray();
		}
	}
}