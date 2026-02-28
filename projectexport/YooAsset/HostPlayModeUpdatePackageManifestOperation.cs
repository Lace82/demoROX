using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x2000081")]
	internal sealed class HostPlayModeUpdatePackageManifestOperation : UpdatePackageManifestOperation
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1BA7800", Offset = "0x1BA6C00", VA = "0x181BA7800")]
		internal HostPlayModeUpdatePackageManifestOperation(HostPlayModeImpl impl, string packageVersion, bool autoSaveVersion, int timeout)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1BA7330", Offset = "0x1BA6730", VA = "0x181BA7330", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1BA7340", Offset = "0x1BA6740", VA = "0x181BA7340", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1BA77E0", Offset = "0x1BA6BE0", VA = "0x181BA77E0", Slot = "11")]
		public override void SavePackageVersion()
		{
		}

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x48")]
		private readonly HostPlayModeImpl _impl;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageVersion;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x58")]
		private readonly bool _autoSaveVersion;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _timeout;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x60")]
		private LoadCacheManifestOperation _tryLoadCacheManifestOp;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x68")]
		private LoadCacheManifestOperation _loadCacheManifestOp;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x70")]
		private DownloadManifestOperation _downloadManifestOp;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x78")]
		private HostPlayModeUpdatePackageManifestOperation.ESteps _steps;

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000DA")]
		private enum ESteps
		{
			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x4000354")]
			None,
			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x4000355")]
			CheckParams,
			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x4000356")]
			CheckActiveManifest,
			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x4000357")]
			TryLoadCacheManifest,
			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x4000358")]
			DownloadManifest,
			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x4000359")]
			LoadCacheManifest,
			// Token: 0x040002DA RID: 730
			[Token(Token = "0x400035A")]
			CheckDeserializeManifest,
			// Token: 0x040002DB RID: 731
			[Token(Token = "0x400035B")]
			Done
		}
	}
}
