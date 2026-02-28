using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GCloud.UQM
{
	// Token: 0x020000F0 RID: 240
	[Token(Token = "0x20000C4")]
	public class UQMMessageCenter : MonoBehaviour
	{
		// Token: 0x060008CF RID: 2255 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x27759A0", Offset = "0x2774DA0", VA = "0x1827759A0")]
		[Attribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xB7320", Offset = "0xB6720")]
		public static string OnUQMRet(int methodId, int crashType, int logUploadResult)
		{
			return null;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000051")]
		public static UQMMessageCenter Instance
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x2776120", Offset = "0x2775520", VA = "0x182776120")]
			get
			{
				return null;
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x2775950", Offset = "0x2774D50", VA = "0x182775950")]
		public void Init()
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x27760D0", Offset = "0x27754D0", VA = "0x1827760D0")]
		public void Uninit()
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x2775C70", Offset = "0x2775070", VA = "0x182775C70")]
		private static string SynchronousDelegate(object arg)
		{
			return null;
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xB96E20", Offset = "0xB96220", VA = "0x180B96E20")]
		public UQMMessageCenter()
		{
		}

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000370")]
		[FieldOffset(Offset = "0x0")]
		private static bool initialzed;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000371")]
		[FieldOffset(Offset = "0x8")]
		private static UQMMessageCenter instance;

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x060008D7 RID: 2263
		[Token(Token = "0x2000160")]
		private delegate string UQMRetJsonEventHandler(int methodId, int callType, int logUploadResult);
	}
}
