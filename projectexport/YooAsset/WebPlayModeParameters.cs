using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x200003C")]
	public class WebPlayModeParameters : InitializeParameters
	{
		// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1BA65B0", Offset = "0x1BA59B0", VA = "0x181BA65B0")]
		public WebPlayModeParameters()
		{
		}

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x38")]
		public IRemoteServices RemoteServices;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x40")]
		public IBuildinQueryServices BuildinQueryServices;
	}
}
