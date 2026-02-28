using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000A4 RID: 164
	[Token(Token = "0x2000077")]
	internal class QueryRemotePackageVersionOperation : AsyncOperationBase
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000331 RID: 817 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000330 RID: 816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000084")]
		public string PackageVersion
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xCB0830", Offset = "0xCAFC30", VA = "0x180CB0830")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xCC8A60", Offset = "0xCC7E60", VA = "0x180CC8A60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1BA7800", Offset = "0x1BA6C00", VA = "0x181BA7800")]
		public QueryRemotePackageVersionOperation(IRemoteServices remoteServices, string packageName, bool appendTimeTicks, int timeout)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1BB0230", Offset = "0x1BAF630", VA = "0x181BB0230", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1BB02B0", Offset = "0x1BAF6B0", VA = "0x181BB02B0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000335 RID: 821 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1BB0150", Offset = "0x1BAF550", VA = "0x181BB0150")]
		private string GetPackageVersionRequestURL(string fileName)
		{
			return null;
		}

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x48")]
		private readonly IRemoteServices _remoteServices;

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x50")]
		private readonly string _packageName;

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x58")]
		private readonly bool _appendTimeTicks;

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x5C")]
		private readonly int _timeout;

		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x60")]
		private UnityWebDataRequester _downloader;

		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x68")]
		private QueryRemotePackageVersionOperation.ESteps _steps;

		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x6C")]
		private int _requestCount;

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageVersion>k__BackingField;

		// Token: 0x020000A5 RID: 165
		[Token(Token = "0x20000D7")]
		private enum ESteps
		{
			// Token: 0x040002AB RID: 683
			[Token(Token = "0x4000343")]
			None,
			// Token: 0x040002AC RID: 684
			[Token(Token = "0x4000344")]
			DownloadPackageVersion,
			// Token: 0x040002AD RID: 685
			[Token(Token = "0x4000345")]
			Done
		}
	}
}
