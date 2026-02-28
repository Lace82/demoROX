using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public interface ITick
	{
		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		void Tick(double deltaTime);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		int GetPriority();
	}
}
