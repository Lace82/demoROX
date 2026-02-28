using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x200003B")]
	public class HostPlayModeParameters : InitializeParameters
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1BA65B0", Offset = "0x1BA59B0", VA = "0x181BA65B0")]
		public HostPlayModeParameters()
		{
		}

		// Token: 0x0400011A RID: 282
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x38")]
		public IRemoteServices RemoteServices;

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x40")]
		public IBuildinQueryServices BuildinQueryServices;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x48")]
		public IDeliveryQueryServices DeliveryQueryServices;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x50")]
		public IDeliveryLoadServices DeliveryLoadServices;
	}
}
