using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D0 RID: 208
	[Token(Token = "0x200009B")]
	public interface IRemoteServices
	{
		// Token: 0x06000489 RID: 1161
		[Token(Token = "0x6000469")]
		string GetRemoteMainURL(string fileName);

		// Token: 0x0600048A RID: 1162
		[Token(Token = "0x600046A")]
		string GetRemoteFallbackURL(string fileName);
	}
}
