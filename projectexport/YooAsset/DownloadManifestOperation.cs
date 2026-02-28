using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x200006E")]
	internal class DownloadManifestOperation : AsyncOperationBase
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1815280", Offset = "0x1814680", VA = "0x181815280")]
		internal DownloadManifestOperation(PersistentManager persistent, IRemoteServices remoteServices, string packageVersion, int timeout)
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1814E30", Offset = "0x1814230", VA = "0x181814E30", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1814EC0", Offset = "0x18142C0", VA = "0x181814EC0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1814DB0", Offset = "0x18141B0", VA = "0x181814DB0")]
		private string GetDownloadRequestURL(string fileName)
		{
			return null;
		}

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x50")]
		private readonly IRemoteServices _remoteServices;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _packageVersion;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x60")]
		private readonly int _timeout;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x68")]
		private UnityWebFileRequester _downloader1;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x70")]
		private UnityWebFileRequester _downloader2;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x78")]
		private DownloadManifestOperation.ESteps _steps;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x7C")]
		private int _requestCount;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x20000CE")]
		private enum ESteps
		{
			// Token: 0x04000246 RID: 582
			[Token(Token = "0x4000316")]
			None,
			// Token: 0x04000247 RID: 583
			[Token(Token = "0x4000317")]
			DownloadPackageHashFile,
			// Token: 0x04000248 RID: 584
			[Token(Token = "0x4000318")]
			DownloadManifestFile,
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000319")]
			Done
		}
	}
}
