using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A6 RID: 166
	[Token(Token = "0x2000078")]
	internal class UnpackBuildinManifestOperation : AsyncOperationBase
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1BA82D0", Offset = "0x1BA76D0", VA = "0x181BA82D0")]
		public UnpackBuildinManifestOperation(PersistentManager persistent, string buildinPackageVersion)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1818200", Offset = "0x1817600", VA = "0x181818200", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1BBB370", Offset = "0x1BBA770", VA = "0x181BBB370", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _buildinPackageVersion;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x58")]
		private UnityWebFileRequester _downloader1;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x60")]
		private UnityWebFileRequester _downloader2;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x68")]
		private UnpackBuildinManifestOperation.ESteps _steps;

		// Token: 0x020000A7 RID: 167
		[Token(Token = "0x20000D8")]
		private enum ESteps
		{
			// Token: 0x040002B4 RID: 692
			[Token(Token = "0x4000347")]
			None,
			// Token: 0x040002B5 RID: 693
			[Token(Token = "0x4000348")]
			UnpackManifestHashFile,
			// Token: 0x040002B6 RID: 694
			[Token(Token = "0x4000349")]
			UnpackManifestFile,
			// Token: 0x040002B7 RID: 695
			[Token(Token = "0x400034A")]
			Done
		}
	}
}
