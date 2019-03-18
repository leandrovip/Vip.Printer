namespace Vip.Printer.Interfaces.Command
{
	internal interface IPaperCut
	{
		byte[] Full();
		byte[] Partial();
	}
}