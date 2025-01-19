using JetBrains.Annotations;

namespace Zyronaa.SDK.Server.IoC
{
	/// <summary>Lifetime of an object</summary>
	[PublicAPI]
	public enum Lifetime
	{
		Transient,
		Singleton
	}
}
