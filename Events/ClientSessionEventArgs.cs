using JetBrains.Annotations;
using Zyronaa.SDK.Core.Models.Player;
using Zyronaa.SDK.Server.Communications;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the session.
		/// </summary>
		/// <value>
		/// The session.
		/// </value>
		public Session Session { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="ClientSessionEventArgs" /> class.
		/// </summary>
		/// <param name="client">The client.</param>
		/// <param name="session">The session.</param>
		public ClientSessionEventArgs(IClient client, Session session) : base(client)
		{
			this.Session = session;
		}
	}
}
