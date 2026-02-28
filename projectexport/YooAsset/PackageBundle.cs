using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x2000089")]
	[Serializable]
	internal class PackageBundle
	{
		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000380 RID: 896 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public string PackageName
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0xCB8250", Offset = "0xCB7650", VA = "0x180CB8250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x105D290", Offset = "0x105C690", VA = "0x18105D290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public string Buildpipeline
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0xCB1390", Offset = "0xCB0790", VA = "0x180CB1390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000088")]
		public string CacheGUID
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000384 RID: 900 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000089")]
		public string FileName
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1BABA50", Offset = "0x1BAAE50", VA = "0x181BABA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000385 RID: 901 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700008A")]
		public string FileExtension
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x1BAB9E0", Offset = "0x1BAADE0", VA = "0x181BAB9E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1BAB640", Offset = "0x1BAAA40", VA = "0x181BAB640")]
		public bool IsRawFileBundle()
		{
			return default(bool);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public PackageBundle()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1BAB6F0", Offset = "0x1BAAAF0", VA = "0x181BAB6F0")]
		public void ParseBundle(PackageManifest manifest)
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1BAB580", Offset = "0x1BAA980", VA = "0x181BAB580")]
		public bool HasTag(string[] tags)
		{
			return default(bool);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1BAB560", Offset = "0x1BAA960", VA = "0x181BAB560")]
		public bool HasAnyTags()
		{
			return default(bool);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1BAB530", Offset = "0x1BAA930", VA = "0x181BAB530")]
		public bool Equals(PackageBundle otherBundle)
		{
			return default(bool);
		}

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x10")]
		public string BundleName;

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		public uint UnityCRC;

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x20")]
		public string FileHash;

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x28")]
		public string FileCRC;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x30")]
		public long FileSize;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x38")]
		public bool Encrypted;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x40")]
		public string[] Tags;

		// Token: 0x04000306 RID: 774
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x48")]
		public int[] DependIDs;

		// Token: 0x04000307 RID: 775
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <Buildpipeline>k__BackingField;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x60")]
		private string _fileName;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x68")]
		private string _fileExtension;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x70")]
		public bool NeedDeCompress;
	}
}
