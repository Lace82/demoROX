using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000062")]
	internal static class ManifestTools
	{
		// Token: 0x060002AC RID: 684 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1BA8FA0", Offset = "0x1BA83A0", VA = "0x181BA8FA0")]
		public static string GetRemoteBundleFileExtension(string bundleName)
		{
			return null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1BA9000", Offset = "0x1BA8400", VA = "0x181BA9000")]
		public static string GetRemoteBundleFileName(int nameStyle, string bundleName, string fileExtension, string fileHash)
		{
			return null;
		}

		// Token: 0x0200007A RID: 122
		[Token(Token = "0x20000C1")]
		private enum EFileNameStyle
		{
			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40002E7")]
			HashName,
			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40002E8")]
			BundleName,
			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40002E9")]
			BundleName_HashName
		}
	}
}
