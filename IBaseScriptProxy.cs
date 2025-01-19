using CitizenFX.Core;

namespace Zyronaa.SDK.Server
{
	public interface IBaseScriptProxy
	{
		EventHandlerDictionary EventHandlers { get; }
		ExportDictionary Exports { get; }
		PlayerList Players { get; }
	}
}
