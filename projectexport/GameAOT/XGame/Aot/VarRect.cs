using System;
using Il2CppDummyDll;
using UnityEngine;
using XGameFramework;

namespace XGame.Aot
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x2000124")]
	public sealed class VarRect : Variable<Rect>
	{
		// Token: 0x06000B15 RID: 2837 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60009CA")]
		[Address(RVA = "0xEDA6F0", Offset = "0xED9AF0", VA = "0x180EDA6F0")]
		public static implicit operator VarRect(Rect value)
		{
			return null;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xEDA6A0", Offset = "0xED9AA0", VA = "0x180EDA6A0")]
		public static implicit operator Rect(VarRect value)
		{
			return default(Rect);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xEDA660", Offset = "0xED9A60", VA = "0x180EDA660")]
		public VarRect()
		{
		}
	}
}
