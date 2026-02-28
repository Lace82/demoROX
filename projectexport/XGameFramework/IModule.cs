using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public interface IModule
	{
		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		void OnInit();

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		void Shutdown();
	}
}
