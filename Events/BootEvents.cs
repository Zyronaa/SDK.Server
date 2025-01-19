using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.Events
{
	/// <summary>
	/// Zyronaa server boot events which are sent over the server event manager.
	/// </summary>
	[PublicAPI]
	public static class BootEvents
	{
		/// <summary>
		/// Event which is used to request the timestamp of when the server started this boot.
		/// </summary>
		public const string GetTime = "zyronaa:server:boot:getTime";

		/// <summary>
		/// Event which is used to request the timestamp of when the server started last boot.
		/// </summary>
		public const string GetLastTime = "zyronaa:server:boot:getLastTime";

		/// <summary>
		/// Event which is used to request the timestamp of when the server shutdown last boot.
		/// </summary>
		public const string GetLastActiveTime = "zyronaa:server:boot:getLastActiveTime";
	}
}
