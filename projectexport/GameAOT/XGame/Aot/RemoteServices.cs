using System;
using Il2CppDummyDll;
using YooAsset;

namespace XGame.Aot
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x20000E1")]
	public class RemoteServices : IRemoteServices
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087D")]
		[Address(RVA = "0xCD69C0", Offset = "0xCD5DC0", VA = "0x180CD69C0")]
		public RemoteServices(string defaultResourceUrl, string fallbackResourceUrl)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600087E")]
		[Address(RVA = "0xECE120", Offset = "0xECD520", VA = "0x180ECE120", Slot = "4")]
		public string GetRemoteMainURL(string fileName)
		{
			return null;
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600087F")]
		[Address(RVA = "0xECE0D0", Offset = "0xECD4D0", VA = "0x180ECE0D0", Slot = "5")]
		public string GetRemoteFallbackURL(string fileName)
		{
			return null;
		}

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x10")]
		private readonly string _defaultResourceUrl;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _fallbackResourceUrl;
	}
}
