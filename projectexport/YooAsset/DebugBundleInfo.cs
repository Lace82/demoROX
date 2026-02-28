using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XGameFramework;

namespace YooAsset
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x200001B")]
	[Serializable]
	internal class DebugBundleInfo : IComparer<DebugBundleInfo>, IComparable<DebugBundleInfo>, IReference
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public string PackageName
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x18122C0", Offset = "0x18116C0", VA = "0x1818122C0", Slot = "5")]
		public int CompareTo(DebugBundleInfo other)
		{
			return 0;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x18122F0", Offset = "0x18116F0", VA = "0x1818122F0", Slot = "4")]
		public int Compare(DebugBundleInfo a, DebugBundleInfo b)
		{
			return 0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x18122B0", Offset = "0x18116B0", VA = "0x1818122B0", Slot = "6")]
		public void Clear()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public DebugBundleInfo()
		{
		}

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <PackageName>k__BackingField;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		public string BundleName;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		public int RefCount;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x24")]
		public BundleLoaderBase.EStatus Status;
	}
}
