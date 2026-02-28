using System;
using Il2CppDummyDll;

namespace GCloud.UQM
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000C3")]
	public class RetArgsWrapper
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x1700004D")]
		public int MethodId
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700004E")]
		public string RetJson
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x1700004F")]
		public int CrashType
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xCC2F30", Offset = "0xCC2330", VA = "0x180CC2F30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x17000050")]
		public int LogUploadResult
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0xCC2F20", Offset = "0xCC2320", VA = "0x180CC2F20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x276F470", Offset = "0x276E870", VA = "0x18276F470")]
		public RetArgsWrapper(int _methodId, string _retJson, int _crashType, int _logUploadResult)
		{
		}

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x10")]
		private readonly int methodId;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x400036D")]
		[FieldOffset(Offset = "0x18")]
		private readonly string retJson;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x400036E")]
		[FieldOffset(Offset = "0x20")]
		private readonly int crashType;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x400036F")]
		[FieldOffset(Offset = "0x24")]
		private readonly int logUploadResult;
	}
}
