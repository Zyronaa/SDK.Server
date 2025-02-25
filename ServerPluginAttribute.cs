using JetBrains.Annotations;
using Zyronaa.SDK.Core;

namespace Zyronaa.SDK.Server
{
	/// <inheritdoc />
	/// <summary>
	/// Specifies the server SDK version number the assembly was built against.
	/// </summary>
	[PublicAPI]
	public class ServerPluginAttribute : PluginAttribute
	{
		/// <inheritdoc />
		/// <summary>
		/// Initializes a new instance of the <see cref="ServerPluginAttribute" /> class.
		/// </summary>
		/// <param name="target">The target server SDK version number.</param>
		public ServerPluginAttribute(uint target) : base(target) { }
	}
}
