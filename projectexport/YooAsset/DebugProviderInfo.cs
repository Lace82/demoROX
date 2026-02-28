using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGameFramework;

namespace YooAsset
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x200001D")]
	[Serializable]
	internal class DebugProviderInfo : IComparer<DebugProviderInfo>, IComparable<DebugProviderInfo>, IReference
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public string PackageName
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002220 File Offset: 0x00000420
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x18122C0", Offset = "0x18116C0", VA = "0x1818122C0", Slot = "5")]
		public int CompareTo(DebugProviderInfo other)
		{
			return 0;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x18122F0", Offset = "0x18116F0", VA = "0x1818122F0", Slot = "4")]
		public int Compare(DebugProviderInfo a, DebugProviderInfo b)
		{
			return 0;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x18124D0", Offset = "0x18118D0", VA = "0x1818124D0", Slot = "6")]
		public void Clear()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public DebugProviderInfo()
		{
		}

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x18")]
		public string AssetPath;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		public string SpawnScene;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		public string SpawnTime;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x30")]
		public float SpawnSecond;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x38")]
		public long LoadingTime;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x40")]
		public int RefCount;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x44")]
		public bool IsSyncLoad;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x48")]
		public EOperationStatus Status;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x50")]
		public List<DebugBundleInfo> DependBundleInfos;
	}
}
