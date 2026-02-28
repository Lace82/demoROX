using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x200005E")]
	public class AssetInfo
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000062")]
		public string PackageName
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xB9DA10", Offset = "0xB9CE10", VA = "0x180B9DA10")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000063")]
		public Type AssetType
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public string Error
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xB99ED0", Offset = "0xB992D0", VA = "0x180B99ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1047110", Offset = "0x1046510", VA = "0x181047110")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000274 RID: 628 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000065")]
		internal string GUID
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x180B970", Offset = "0x180AD70", VA = "0x18180B970")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x17000066")]
		internal bool IsInvalid
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x17EC2B0", Offset = "0x17EB6B0", VA = "0x1817EC2B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000276 RID: 630 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000067")]
		public string Address
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x180B8B0", Offset = "0x180ACB0", VA = "0x18180B8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000068")]
		public string AssetPath
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x180B920", Offset = "0x180AD20", VA = "0x18180B920")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000069")]
		public string AssetGuid
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x180B900", Offset = "0x180AD00", VA = "0x18180B900")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		private AssetInfo()
		{
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x180B7B0", Offset = "0x180ABB0", VA = "0x18180B7B0")]
		internal AssetInfo(string packageName, PackageAsset packageAsset, Type assetType)
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x180B700", Offset = "0x180AB00", VA = "0x18180B700")]
		internal AssetInfo(string packageName, string error)
		{
		}

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x10")]
		private readonly PackageAsset _packageAsset;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x18")]
		private string _providerGUID;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private Type <AssetType>k__BackingField;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <Error>k__BackingField;
	}
}
