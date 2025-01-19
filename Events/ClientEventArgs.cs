using System;
using JetBrains.Annotations;
using Zyronaa.SDK.Server.Communications;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public class ClientEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the client.
		/// </summary>
		/// <value>
		/// The client.
		/// </value>
		public IClient Client { get; }

		/// <param name="client">The client.</param>
		public ClientEventArgs(IClient client)
		{
			this.Client = client;
		}
	}
}
