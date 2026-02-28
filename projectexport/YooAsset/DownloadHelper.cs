using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YooAsset
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x2000024")]
	internal static class DownloadHelper
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public static List<long> ClearFileResponseCodes
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x1814300", Offset = "0x1813700", VA = "0x181814300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x18143C0", Offset = "0x18137C0", VA = "0x1818143C0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1814220", Offset = "0x1813620", VA = "0x181814220")]
		public static UnityWebRequest NewRequest(string requestURL)
		{
			return null;
		}

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static List<long> <ClearFileResponseCodes>k__BackingField;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x8")]
		public static DownloadRequestDelegate RequestDelegate;
	}
}
