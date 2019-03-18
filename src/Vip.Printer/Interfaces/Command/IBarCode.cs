namespace Vip.Printer.Interfaces.Command
{
	public interface IBarCode
	{
		byte[] Code128(string code);
		byte[] Code39(string code);
		byte[] Ean13(string code);
	}
}