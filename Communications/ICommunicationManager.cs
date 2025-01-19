using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.Communications
{
	[PublicAPI]
	public interface ICommunicationManager
	{
		ICommunicationTarget Event(string @event);
	}
}
