using JetBrains.Annotations;
using Zyronaa.SDK.Core.Models.Player;
using Zyronaa.SDK.Server.Communications;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public class ClientReconnectEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the old session.
		/// </summary>
		/// <value>
		/// The old session.
		/// </value>
		public Session OldSession { get; }

		/// <summary>
		/// Gets the new session.
		/// </summary>
		/// <value>
		/// The new session.
		/// </value>
		public Session NewSession { get; }

		/// <param name="client">The client.</param>
		/// <param name="oldSession">The old session.</param>
		/// <param name="newSession">The new session.</param>
		public ClientReconnectEventArgs(IClient client, Session oldSession, Session newSession) : base(client)
		{
			this.OldSession = oldSession;
			this.NewSession = newSession;
		}
	}
}
