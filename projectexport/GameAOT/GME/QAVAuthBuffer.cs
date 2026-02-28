using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GME
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x200008A")]
	public class QAVAuthBuffer
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public QAVAuthBuffer()
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x276B7E0", Offset = "0x276ABE0", VA = "0x18276B7E0")]
		public static byte[] GenAuthBuffer(int appId, string roomID, string openId, string key)
		{
			return null;
		}

		// Token: 0x060005E2 RID: 1506
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x276B960", Offset = "0x276AD60", VA = "0x18276B960")]
		[PreserveSig]
		private static extern int QAVSDK_AuthBuffer_GenAuthBuffer(int appId, string roomID, string openID, string key, byte[] retAuthBuff, int buffLength);

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x40002AA")]
		public const string MyLibName = "gmesdk";
	}
}
