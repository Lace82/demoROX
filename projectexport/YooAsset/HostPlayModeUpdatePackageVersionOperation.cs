using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x2000086")]
	internal sealed class HostPlayModeUpdatePackageVersionOperation : UpdatePackageVersionOperation
	{
		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1BA7A20", Offset = "0x1BA6E20", VA = "0x181BA7A20")]
		internal HostPlayModeUpdatePackageVersionOperation(HostPlayModeImpl impl, bool appendTimeTicks, int timeout)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1BA7870", Offset = "0x1BA6C70", VA = "0x181BA7870", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x50")]
		private readonly HostPlayModeImpl _impl;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x58")]
		private readonly bool _appendTimeTicks;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _timeout;

		// Token: 0x040002EB RID: 747
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x60")]
		private QueryRemotePackageVersionOperation _queryRemotePackageVersionOp;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x68")]
		private HostPlayModeUpdatePackageVersionOperation.ESteps _steps;

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000DC")]
		private enum ESteps
		{
			// Token: 0x040002EE RID: 750
			[Token(Token = "0x4000363")]
			None,
			// Token: 0x040002EF RID: 751
			[Token(Token = "0x4000364")]
			QueryRemotePackageVersion,
			// Token: 0x040002F0 RID: 752
			[Token(Token = "0x4000365")]
			Done
		}
	}
}
