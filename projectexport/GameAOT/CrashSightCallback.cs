using System;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000004")]
public abstract class CrashSightCallback
{
	// Token: 0x0600003F RID: 63
	[Token(Token = "0x600003B")]
	public abstract string OnCrashBaseRetEvent(int methodId, int crashType);

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
	protected CrashSightCallback()
	{
	}
}
