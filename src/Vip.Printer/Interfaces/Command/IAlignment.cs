namespace Vip.Printer.Interfaces.Command
{
	internal interface IAlignment
	{
		byte[] Left();
		byte[] Right();
		byte[] Center();
	}
}