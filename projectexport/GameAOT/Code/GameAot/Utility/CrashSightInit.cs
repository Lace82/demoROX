using System;
using Il2CppDummyDll;

namespace Code.GameAot.Utility
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x2000062")]
	public static class CrashSightInit
	{
		// Token: 0x06000473 RID: 1139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0")]
		public static void Init(string version)
		{
		}

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x40001E3")]
		public const string CRASH_SIGHT_APP_ID_FOR_ANDROID = "c056b3da6f";

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x40001E4")]
		public const string CRASH_SIGHT_APP_KEY_FOR_ANDROID = "b845afcb-a44b-4ddb-9843-5e7a4e4c0145";

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x40001E5")]
		public const string CRASH_SIGHT_UPLOAD_URL_ANDROID = "https://android.crashsight.qq.com/pb/async";

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x40001E6")]
		public const string CRASH_SIGHT_APP_ID_FOR_IOS = "35e51e868c";

		// Token: 0x0400029F RID: 671
		[Token(Token = "0x40001E7")]
		public const string CRASH_SIGHT_APP_KEY_FOR_IOS = "b466ce76-7a36-41f5-b623-9b8793ca0d02";

		// Token: 0x040002A0 RID: 672
		[Token(Token = "0x40001E8")]
		public const string CRASH_SIGHT_UPLOAD_URL_IOS = "https://ios.crashsight.qq.com/pb/sync";

		// Token: 0x040002A1 RID: 673
		[Token(Token = "0x40001E9")]
		public const string CRASH_SIGHT_APP_ID_FOR_WINDOWS = "43f78fcca6";

		// Token: 0x040002A2 RID: 674
		[Token(Token = "0x40001EA")]
		public const string CRASH_SIGHT_UPLOAD_URL_WINDOWS = "https://android.crashsight.qq.com/pb/async";

		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40001EB")]
		public const string CRASH_SIGHT_APP_KEY_FOR_WINDOWS = "df4aba3e-8cf9-483c-ad75-ac227e173be9";

		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40001EC")]
		private const string CRASH_SIGHT_USER_ID = "pcbeforeuserid";

		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40001ED")]
		private const string CRASH_SIGHT_APP_VERSION = "1.0";
	}
}
