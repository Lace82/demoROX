using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x20000D6")]
	[Attribute(Name = "LuaCallCSharpAttribute", RVA = "0x90BA0", Offset = "0x8FFA0")]
	public static class GameConfig
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x137A900", Offset = "0x1379D00", VA = "0x18137A900")]
		public static string ClientVersion()
		{
			return null;
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x137AA60", Offset = "0x1379E60", VA = "0x18137AA60")]
		public static void RefreshVersion()
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x137AA30", Offset = "0x1379E30", VA = "0x18137AA30")]
		public static string GetPlatformKeyword()
		{
			return null;
		}

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x0")]
		public static AppConfig RoAppConfig;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x8")]
		public static AppVersion RoAppVersion;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40003D6")]
		[FieldOffset(Offset = "0x10")]
		public static UrlList EntryURLList;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40003D7")]
		[FieldOffset(Offset = "0x18")]
		public static UrlList AccountURLList;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40003D8")]
		[FieldOffset(Offset = "0x20")]
		public static string ClientLogURL;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40003D9")]
		[FieldOffset(Offset = "0x28")]
		public static string UpLoadImageURL;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40003DA")]
		[FieldOffset(Offset = "0x30")]
		public static string SecretURL;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40003DB")]
		[FieldOffset(Offset = "0x38")]
		public static bool ShowDebugTools;

		// Token: 0x040004AF RID: 1199
		[Token(Token = "0x40003DC")]
		[FieldOffset(Offset = "0x39")]
		public static bool IsShowGiftButton;

		// Token: 0x040004B0 RID: 1200
		[Token(Token = "0x40003DD")]
		[FieldOffset(Offset = "0x3A")]
		public static bool IsOpenDiamondAuction;

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40003DE")]
		[FieldOffset(Offset = "0x40")]
		public static string SensorsServerUrl;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40003DF")]
		[FieldOffset(Offset = "0x48")]
		public static string AppDownloadURL;

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40003E0")]
		[FieldOffset(Offset = "0x50")]
		public static string IsOpenLive;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40003E1")]
		public const string BUNDLE_PACKAGE = "bundles";

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40003E2")]
		public const string DAT_PACKAGE = "dats";

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40003E3")]
		public const string PLAY_MODE = "PLAY_MODE";

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40003E4")]
		public const string DAT_DOWN_LOADER = "DAT_DOWN_LOADER";

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40003E5")]
		public const string BUNDLE_DOWN_LOADER = "BUNDLE_DOWN_LOADER";

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40003E6")]
		public const string BUNDLE_CDN = "BUNDLE_CDN";

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40003E7")]
		public const string DAT_CDN = "DAT_CDN";

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40003E8")]
		public const int DOWN_LOAD_MAX_UNM = 10;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x58")]
		public static int SeparateDownLoadMaxNum;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40003EA")]
		public const int DOWN_LOAD_MAX_RETRY = 3;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40003EB")]
		public const string RESTART_DOWN_LOAD = "RESTART_DOWN_LOAD";

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40003EC")]
		public const string SEPARATE_DOWNLOAD_MAX_NUM = "SEPARATE_DOWNLOAD_MAX_NUM";

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40003ED")]
		public const int DOWN_LOAD_TIME_OUT = 8;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40003EE")]
		[FieldOffset(Offset = "0x5C")]
		public static float GamePauseNetCount;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40003EF")]
		public const string DEFAULT_VERSION = "0.0";

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40003F0")]
		[FieldOffset(Offset = "0x60")]
		public static string SecretKey;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40003F1")]
		[FieldOffset(Offset = "0x68")]
		private static string _clientVersion;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40003F2")]
		[FieldOffset(Offset = "0x70")]
		public static string LauncherCGPath;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40003F3")]
		[FieldOffset(Offset = "0x78")]
		public static string LauncherBGPath;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40003F4")]
		public const string UWA_DISABLE_SDK = "DISABLE_UWA_SDK";

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40003F5")]
		[FieldOffset(Offset = "0x80")]
		public static string EntryData;
	}
}
