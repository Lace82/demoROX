using System;
using Il2CppDummyDll;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200016A RID: 362
	[Token(Token = "0x2000112")]
	public class DefaultLog : XGameFrameworkLog.ILogHelper
	{
		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1379180", Offset = "0x1378580", VA = "0x181379180", Slot = "4")]
		public void Log(XGameFrameworkLogLevel level, object message)
		{
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1378FF0", Offset = "0x13783F0", VA = "0x181378FF0")]
		private static object GetLuaStackInfo(object message)
		{
			return null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000998")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public DefaultLog()
		{
		}
	}
}
