using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.Events
{
	/// <summary>
	/// Core Zyronaa server events which are sent over the server event manager.
	/// </summary>
	[PublicAPI]
	public static class ServerEvents
	{
		/// <summary>
		/// The server initialized event.
		/// Fired as soon as the server has initialized.
		/// </summary>
		public const string ServerInitialized = "zyronaa:server:serverInitialized";

		public const string HostingSession = "zyronaa:server:hostingSession";

		public const string HostedSession = "zyronaa:server:hostedSession";

		public const string PlayerConnecting = "zyronaa:server:playerConnecting";

		public const string PlayerDropped = "zyronaa:server:playerDropped";

		public const string ResourceStart = "zyronaa:server:resourceStart";

		public const string ResourceStop = "zyronaa:server:resourceStop";

		public const string RconCommand = "zyronaa:server:rconCommand";

		public const string Explosion = "zyronaa:server:explosion";
	}
}
