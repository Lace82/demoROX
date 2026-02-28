using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x2000087")]
	internal sealed class WebPlayModeUpdatePackageVersionOperation : UpdatePackageVersionOperation
	{
		// Token: 0x0600037A RID: 890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x3899170", Offset = "0x3898570", VA = "0x183899170")]
		internal WebPlayModeUpdatePackageVersionOperation(WebPlayModeImpl impl, bool appendTimeTicks, int timeout)
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x3898FD0", Offset = "0x38983D0", VA = "0x183898FD0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x50")]
		private readonly WebPlayModeImpl _impl;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x58")]
		private readonly bool _appendTimeTicks;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _timeout;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x60")]
		private QueryRemotePackageVersionOperation _queryRemotePackageVersionOp;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x68")]
		private WebPlayModeUpdatePackageVersionOperation.ESteps _steps;

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000DD")]
		private enum ESteps
		{
			// Token: 0x040002F7 RID: 759
			[Token(Token = "0x4000367")]
			None,
			// Token: 0x040002F8 RID: 760
			[Token(Token = "0x4000368")]
			QueryRemotePackageVersion,
			// Token: 0x040002F9 RID: 761
			[Token(Token = "0x4000369")]
			Done
		}
	}
}
