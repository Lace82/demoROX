using System;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000109 RID: 265
	[Token(Token = "0x20000D8")]
	public class EntryEvent
	{
		// Token: 0x06000950 RID: 2384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600085B")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public EntryEvent()
		{
		}

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40003FD")]
		private const string ENTRY_PREFIX = "Entry_";

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40003FE")]
		public const string GAME_FLOW_SPLASH_START = "Entry_GAME_FLOW_SPLASH_START";

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40003FF")]
		public const string GAME_FLOW_SPLASH_END = "Entry_GAME_FLOW_SPLASH_END";

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x4000400")]
		public const string PATCH_UPDATE_RESOURCE_INFO = "Entry_PATCH_UPDATE_RESOURCE_INFO";

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x4000401")]
		public const string PATCH_UPDATE_RES_VERSION = "Entry_PATCH_UPDATE_RES_VERSION";

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x4000402")]
		public const string PATCH_UPDATE_CFG_VERSION = "Entry_PATCH_UPDATE_CFG_VERSION";

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x4000403")]
		public const string QUERY_GAME_VERSION_START = "Entry_QUERY_GAME_VERSION_START";

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x4000404")]
		public const string QUERY_GAME_VERSION_END = "Entry_QUERY_GAME_VERSION_END";

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x4000405")]
		public const string CHECK_APP_VERSION = "Entry_CHECK_APP_VERSION";

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x4000406")]
		public const string CHECK_VERSION_FAILURE = "Entry_CHECK_VERSION_FAILURE";

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x4000407")]
		public const string ENSURE_HOT_UPDATE = "Entry_ENSURE_HOT_UPDATE";

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x4000408")]
		public const string RESTART_DOWN_FILE = "Entry_RESTART_DOWN_FILE";

		// Token: 0x040004DE RID: 1246
		[Token(Token = "0x4000409")]
		public const string DOWN_LOAD_FILE_FAILURE = "Entry_DOWN_LOAD_FILE_FAILURE";

		// Token: 0x040004DF RID: 1247
		[Token(Token = "0x400040A")]
		public const string DOWN_LOAD_PROGRESS = "Entry_DOWN_LOAD_PROGRESS";

		// Token: 0x040004E0 RID: 1248
		[Token(Token = "0x400040B")]
		public const string FORCE_UPDATE_DOWN_LOAD_PROGRESS = "Entry_FORCE_UPDATE_DOWN_LOAD_PROGRESS";

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x400040C")]
		public const string PATCH_DONE = "Entry_PATCH_DONE";

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x400040D")]
		public const string PATCH_PREPARE_END = "Entry_PATCH_PREPARE_END";

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x400040E")]
		public const string PATCH_DOWN_LOAD_FILE_BEGIN_POINT = "PATCH_DOWN_LOAD_FILE_BEGIN_POINT";

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x400040F")]
		public const string PATCH_DOWN_LOAD_FILE_END_POINT = "PATCH_DOWN_LOAD_FILE_END_POINT";

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x4000410")]
		public const string FORCE_DOWN_LOAD_FULL = "Entry_FORCE_DOWN_LOAD_FULL";

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x4000411")]
		public const string FORCE_DOWN_LOAD_SEPARATE = "Entry_FORCE_DOWN_LOAD_SEPARATE";

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x4000412")]
		public const string PLAYER_CANCLE_DOWN_SEPARATE = "Entry_PLAYER_CANCLE_DOWN_SEPARATE";

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x4000413")]
		public const string PATCH_SEPARATE_DOWN_LOAD_DONE = "Entry_PATCH_SEPARATE_DOWN_LOAD_DONE";

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x4000414")]
		public const string LAUNCH_OPERATE_TYPE = "Entry_LAUNCH_OPERATE_TYPE";

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x4000415")]
		public const string UI_LAUNCH_PROGRESS = "Entry_UI_LAUNCH_PROGRESS";

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x4000416")]
		public const string LAUNCH_DONE = "Entry_LAUNCH_DONE";

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x4000417")]
		public const string CONFIRM_DOWN_LOAD_IN_4G = "Entry_CONFIRM_DOWN_LOAD_IN_4G";
	}
}
