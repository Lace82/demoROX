using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000068")]
	internal sealed class EditorSimulateModeInitializationOperation : InitializationOperation
	{
		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1818390", Offset = "0x1817790", VA = "0x181818390")]
		internal EditorSimulateModeInitializationOperation(EditorSimulateModeImpl impl, string simulateManifestFilePath)
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1818210", Offset = "0x1817610", VA = "0x181818210", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x50")]
		private readonly EditorSimulateModeImpl _impl;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _simulateManifestFilePath;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x60")]
		private LoadEditorManifestOperation _loadEditorManifestOp;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x68")]
		private EditorSimulateModeInitializationOperation.ESteps _steps;

		// Token: 0x02000088 RID: 136
		[Token(Token = "0x20000C9")]
		private enum ESteps
		{
			// Token: 0x04000204 RID: 516
			[Token(Token = "0x40002F5")]
			None,
			// Token: 0x04000205 RID: 517
			[Token(Token = "0x40002F6")]
			LoadEditorManifest,
			// Token: 0x04000206 RID: 518
			[Token(Token = "0x40002F7")]
			Done
		}
	}
}
