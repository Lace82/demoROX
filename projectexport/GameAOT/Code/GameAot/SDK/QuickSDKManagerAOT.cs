using System;
using Il2CppDummyDll;
using XGame.Aot;

namespace Code.GameAot.SDK
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000066")]
	public class QuickSDKManagerAOT : PlatformManagerAOT
	{
		// Token: 0x06000488 RID: 1160 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x276F3A0", Offset = "0x276E7A0", VA = "0x18276F3A0")]
		public AppConfig GetAppConfig()
		{
			return null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "4")]
		public override void InitSDK()
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public QuickSDKManagerAOT()
		{
		}
	}
}
