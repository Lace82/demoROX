using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NetEase
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000028")]
	public class HTPCallback : AndroidJavaProxy
	{
		// Token: 0x060002EA RID: 746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x1D31FC0", Offset = "0x1D313C0", VA = "0x181D31FC0")]
		public HTPCallback()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		public virtual void onReceive(int code, string msg)
		{
		}
	}
}
