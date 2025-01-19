using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Zyronaa.SDK.Core.Models.Player;
using Zyronaa.SDK.Server.Events;

namespace Zyronaa.SDK.Server.Communications
{
	[PublicAPI]
	public interface IClientList
	{
		/// <summary>
		/// Gets the clients.
		/// </summary>
		/// <value>
		/// The clients.
		/// </value>
		Dictionary<Session,IClient> Clients { get; }

		/// <summary>
		/// Occurs when [client added].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientAdded;

		/// <summary>
		/// Occurs when [client removed].
		/// </summary>
		event EventHandler<ClientEventArgs> ClientRemoved;
	}
}
