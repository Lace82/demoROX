using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000A2")]
	public interface ILogger
	{
		// Token: 0x060004C8 RID: 1224
		[Token(Token = "0x60004A8")]
		void Log(string message);

		// Token: 0x060004C9 RID: 1225
		[Token(Token = "0x60004A9")]
		void Warning(string message);

		// Token: 0x060004CA RID: 1226
		[Token(Token = "0x60004AA")]
		void Error(string message);

		// Token: 0x060004CB RID: 1227
		[Token(Token = "0x60004AB")]
		void Exception(Exception exception);
	}
}
