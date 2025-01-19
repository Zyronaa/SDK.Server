using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public static class SessionEvents
	{
		/// <summary>
		/// The disconnect player event.
		/// Used to disconnect a player from the server.
		/// </summary>
		public const string DisconnectPlayer = "zyronaa:server:sessionmanager:disconnectPlayer";

		/// <summary>
		/// The client connecting event.
		/// Fired when a client starts connecting.
		/// </summary>
		public const string ClientConnecting = "zyronaa:server:sessionmanager:clientConnecting";

		/// <summary>
		/// The user creating event.
		/// Fired when a user is being created for a client; immediately after the client starts connecting.
		/// </summary>
		public const string UserCreating = "zyronaa:server:sessionmanager:userCreating";

		/// <summary>
		/// The user created event.
		/// Fired when a user has been created for a client.
		/// </summary>
		public const string UserCreated = "zyronaa:server:sessionmanager:userCreated";

		/// <summary>
		/// The session creating event.
		/// Fired when a session is being created for a user; immediately after a user has been created.
		/// </summary>
		public const string SessionCreating = "zyronaa:server:sessionmanager:sessionCreating";

		/// <summary>
		/// The session created event.
		/// Fired when a session has been created for a user.
		/// </summary>
		public const string SessionCreated = "zyronaa:server:sessionmanager:sessionCreated";

		/// <summary>
		/// The client connected event.
		/// Fired when a client has connected to the server; immediately after a session has been created.
		/// </summary>
		public const string ClientConnected = "zyronaa:server:sessionmanager:clientConnected";

		/// <summary>
		/// The client reconnecting event.
		/// Fired when a client is connecting to the server during their disconnect grace period.
		/// </summary>
		public const string ClientReconnecting = "zyronaa:server:sessionmanager:clientReconnecting";

		/// <summary>
		/// The client reconnecting event.
		/// Fired when a client has connected to the server during their disconnect grace period.
		/// </summary>
		public const string ClientReconnected = "zyronaa:server:sessionmanager:clientReconnected";

		/// <summary>
		/// The client disconnecting event.
		/// Fired when a client is disconnecting from the server.
		/// </summary>
		public const string ClientDisconnecting = "zyronaa:server:sessionmanager:clientDisconnecting";

		/// <summary>
		/// The client disconnected event.
		/// Fired when a client has disconnected from the server.
		/// </summary>
		public const string ClientDisconnected = "zyronaa:server:sessionmanager:clientDisconnected";

		/// <summary>
		/// The client initializing event.
		/// Fired when the client is initializing.
		/// </summary>
		public const string ClientInitializing = "zyronaa:server:sessionmanager:clientInitializing";

		/// <summary>
		/// The client initialized event.
		/// Fired when the client has initialized.
		/// </summary>
		public const string ClientInitialized = "zyronaa:server:sessionmanager:clientInitialized";

		/// <summary>
		/// The session timed out.
		/// Fired when a client session times out.
		/// </summary>
		public const string SessionTimedOut = "zyronaa:server:sessionmanager:sessionTimedOut";

		/// <summary>
		/// The get maximum players event.
		/// Used to request the configured maximum players.
		/// </summary>
		public const string GetMaxPlayers = "zyronaa:server:sessionmanager:getMaxPlayers";

		/// <summary>
		/// The get current sessions count events.
		/// Used to request the current session count.
		/// </summary>
		public const string GetCurrentSessionsCount = "zyronaa:server:sessionmanager:getCurrentSessionsCount";

		/// <summary>
		/// The get current sessions event.
		/// Used to request a list of the current sessions.
		/// </summary>
		public const string GetCurrentSessions = "zyronaa:server:sessionmanager:getCurrentSessions";
	}
}
