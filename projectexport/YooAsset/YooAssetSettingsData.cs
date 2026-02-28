using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x200009D")]
	internal static class YooAssetSettingsData
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700009F")]
		public static YooAssetSettings Setting
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x3899E70", Offset = "0x3899270", VA = "0x183899E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x3899D70", Offset = "0x3899170", VA = "0x183899D70")]
		private static void LoadSettingData()
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x3899B20", Offset = "0x3898F20", VA = "0x183899B20")]
		public static string GetReportFileName(string packageName, string packageVersion)
		{
			return null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x38991D0", Offset = "0x38985D0", VA = "0x1838991D0")]
		public static string GetManifestBinaryFileName(string packageName, string packageVersion)
		{
			return null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x38994C0", Offset = "0x38988C0", VA = "0x1838994C0")]
		public static string GetManifestJsonFileName(string packageName, string packageVersion)
		{
			return null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x38997B0", Offset = "0x3898BB0", VA = "0x1838997B0")]
		public static string GetPackageHashFileName(string packageName, string packageVersion)
		{
			return null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x3899AA0", Offset = "0x3898EA0", VA = "0x183899AA0")]
		public static string GetPackageVersionFileName(string packageName)
		{
			return null;
		}

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x74717")]
		private static YooAssetSettings _setting;
	}
}
