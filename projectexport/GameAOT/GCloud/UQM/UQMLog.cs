using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x020000ED RID: 237
	[Token(Token = "0x20000C2")]
	internal class UQMLog
	{
		// Token: 0x060008C3 RID: 2243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x27758B0", Offset = "0x2774CB0", VA = "0x1827758B0")]
		public static void SetLevel(UQMLog.Level l)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x2775810", Offset = "0x2774C10", VA = "0x182775810")]
		public static void Log(string message)
		{
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x2775770", Offset = "0x2774B70", VA = "0x182775770")]
		public static void LogWarning(string message)
		{
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x27756D0", Offset = "0x2774AD0", VA = "0x1827756D0")]
		public static void LogError(string message)
		{
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x27755B0", Offset = "0x27749B0", VA = "0x1827755B0")]
		public static void FullLog(string message)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public UQMLog()
		{
		}

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x50070")]
		private static UQMLog.Level level;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x400036B")]
		private const string header = "[CrashSightPlugin-Unity]";

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x200015F")]
		public enum Level
		{
			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x4000579")]
			None,
			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x400057A")]
			Log,
			// Token: 0x0400042D RID: 1069
			[Token(Token = "0x400057B")]
			Warning,
			// Token: 0x0400042E RID: 1070
			[Token(Token = "0x400057C")]
			Error
		}
	}
}
