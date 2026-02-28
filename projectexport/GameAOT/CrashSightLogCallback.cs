using System;
using Il2CppDummyDll;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000005")]
public abstract class CrashSightLogCallback
{
	// Token: 0x06000041 RID: 65
	[Token(Token = "0x600003D")]
	public abstract string OnSetLogPathEvent(int methodId, int crashType);

	// Token: 0x06000042 RID: 66
	[Token(Token = "0x600003E")]
	public abstract void OnLogUploadResultEvent(int methodId, int crashType, int result);

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
	protected CrashSightLogCallback()
	{
	}
}
