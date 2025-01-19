using JetBrains.Annotations;
using Zyronaa.SDK.Server.Communications;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public class ClientDeferralsEventArgs : ClientEventArgs
	{
		/// <summary>
		/// Gets the deferrals.
		/// </summary>
		/// <value>
		/// The deferrals.
		/// </value>
		public IConnectionDeferrals Deferrals { get; }

		/// <param name="client">The client.</param>
		/// <param name="deferrals">The deferrals.</param>
		public ClientDeferralsEventArgs(IClient client, IConnectionDeferrals deferrals) : base(client)
		{
			this.Deferrals = deferrals;
		}
	}
}
