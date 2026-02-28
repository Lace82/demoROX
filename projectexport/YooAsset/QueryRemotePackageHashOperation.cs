using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x2000076")]
	internal class QueryRemotePackageHashOperation : AsyncOperationBase
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600032B RID: 811 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000083")]
		public string PackageHash
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x8EF970", Offset = "0x8EED70", VA = "0x1808EF970")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xCD51C0", Offset = "0xCD45C0", VA = "0x180CD51C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1BA8F30", Offset = "0x1BA8330", VA = "0x181BA8F30")]
		public QueryRemotePackageHashOperation(IRemoteServices remoteServices, string packageName, string packageVersion, int timeout)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1BAFE20", Offset = "0x1BAF220", VA = "0x181BAFE20", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1BAFEA0", Offset = "0x1BAF2A0", VA = "0x181BAFEA0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1BAFDA0", Offset = "0x1BAF1A0", VA = "0x181BAFDA0")]
		private string GetPackageHashRequestURL(string fileName)
		{
			return null;
		}

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x48")]
		private readonly IRemoteServices _remoteServices;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageName;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x58")]
		private readonly string _packageVersion;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x60")]
		private readonly int _timeout;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x68")]
		private UnityWebDataRequester _downloader;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x70")]
		private QueryRemotePackageHashOperation.ESteps _steps;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x74")]
		private int _requestCount;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x78")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageHash>k__BackingField;

		// Token: 0x020000A3 RID: 163
		[Token(Token = "0x20000D6")]
		private enum ESteps
		{
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400033F")]
			None,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x4000340")]
			DownloadPackageHash,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x4000341")]
			Done
		}
	}
}
