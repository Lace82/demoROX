using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x2000072")]
	internal class LoadRemoteManifestOperation : AsyncOperationBase
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000316 RID: 790 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000315 RID: 789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public PackageManifest Manifest
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xCB0810", Offset = "0xCAFC10", VA = "0x180CB0810")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xDA59B0", Offset = "0xDA4DB0", VA = "0x180DA59B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1BA8F30", Offset = "0x1BA8330", VA = "0x181BA8F30")]
		internal LoadRemoteManifestOperation(IRemoteServices remoteServices, string packageName, string packageVersion, int timeout)
		{
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1BA89C0", Offset = "0x1BA7DC0", VA = "0x181BA89C0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1BA8A40", Offset = "0x1BA7E40", VA = "0x181BA8A40", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1BA8940", Offset = "0x1BA7D40", VA = "0x181BA8940")]
		private string GetDownloadRequestURL(string fileName)
		{
			return null;
		}

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x48")]
		private readonly IRemoteServices _remoteServices;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageName;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _packageVersion;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x60")]
		private readonly int _timeout;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x68")]
		private QueryRemotePackageHashOperation _queryRemotePackageHashOp;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x70")]
		private UnityWebDataRequester _downloader;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x78")]
		private DeserializeManifestOperation _deserializer;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x80")]
		private byte[] _fileData;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x88")]
		private LoadRemoteManifestOperation.ESteps _steps;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x8C")]
		private int _requestCount;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private PackageManifest <Manifest>k__BackingField;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x20000D2")]
		private enum ESteps
		{
			// Token: 0x04000279 RID: 633
			[Token(Token = "0x400032C")]
			None,
			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400032D")]
			DownloadPackageHashFile,
			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400032E")]
			DownloadManifestFile,
			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400032F")]
			VerifyFileHash,
			// Token: 0x0400027D RID: 637
			[Token(Token = "0x4000330")]
			CheckDeserializeManifest,
			// Token: 0x0400027E RID: 638
			[Token(Token = "0x4000331")]
			Done
		}
	}
}
