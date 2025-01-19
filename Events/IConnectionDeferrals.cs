using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.Events
{
	[PublicAPI]
	public interface IConnectionDeferrals
	{
		string Message { set; }

		void Defer();

		void ShowCard(string json);

		void Allow();

		void Reject(string message);
	}
}
