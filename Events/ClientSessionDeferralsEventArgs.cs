using JetBrains.Annotations;
using Zyronaa.SDK.Core.Models.Player;
using Zyronaa.SDK.Server.Communications;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public class ClientSessionDeferralsEventArgs : ClientSessionEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public IConnectionDeferrals Deferrals { get; }

		/// <param name="client">The client.</param>
		/// <param name="session">The session.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientSessionDeferralsEventArgs(IClient client, Session session, IConnectionDeferrals deferrals) : base(client, session)
		{
			this.Deferrals = deferrals;
		}
	}
}
