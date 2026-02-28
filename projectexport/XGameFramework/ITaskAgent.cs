using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	internal interface ITaskAgent<T> where T : TaskBase
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000C3 RID: 195
		[Token(Token = "0x17000021")]
		T Task { [Token(Token = "0x60000C3")] get; }

		// Token: 0x060000C4 RID: 196
		[Token(Token = "0x60000C4")]
		void Initialize();

		// Token: 0x060000C5 RID: 197
		[Token(Token = "0x60000C5")]
		void Shutdown();

		// Token: 0x060000C6 RID: 198
		[Token(Token = "0x60000C6")]
		void Reset();

		// Token: 0x060000C7 RID: 199
		[Token(Token = "0x60000C7")]
		void Tick(double deltaTime);

		// Token: 0x060000C8 RID: 200
		[Token(Token = "0x60000C8")]
		EStartTaskStatus Start(T task);
	}
}
