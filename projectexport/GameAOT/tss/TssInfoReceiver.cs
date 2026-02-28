using System;
using Il2CppDummyDll;

namespace tss
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000025")]
	public interface TssInfoReceiver
	{
		// Token: 0x060002D4 RID: 724
		[Token(Token = "0x6000231")]
		void onReceive(int tssInfoType, string info);
	}
}
