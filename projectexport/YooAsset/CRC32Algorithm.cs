using System;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000A1")]
	internal class CRC32Algorithm : HashAlgorithm
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1810D60", Offset = "0x1810160", VA = "0x181810D60")]
		public CRC32Algorithm()
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1810B10", Offset = "0x180FF10", VA = "0x181810B10", Slot = "18")]
		public override void Initialize()
		{
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x18108D0", Offset = "0x180FCD0", VA = "0x1818108D0", Slot = "19")]
		protected override void HashCore(byte[] input, int offset, int length)
		{
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1810970", Offset = "0x180FD70", VA = "0x181810970", Slot = "20")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1810330", Offset = "0x180F730", VA = "0x181810330")]
		public static uint Append(uint initial, byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1810440", Offset = "0x180F840", VA = "0x181810440")]
		public static uint Append(uint initial, byte[] input)
		{
			return 0U;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1810850", Offset = "0x180FC50", VA = "0x181810850")]
		public static uint Compute(byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1810780", Offset = "0x180FB80", VA = "0x181810780")]
		public static uint Compute(byte[] input)
		{
			return 0U;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x18104E0", Offset = "0x180F8E0", VA = "0x1818104E0")]
		public static uint ComputeAndWriteToEnd(byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x18106D0", Offset = "0x180FAD0", VA = "0x1818106D0")]
		public static uint ComputeAndWriteToEnd(byte[] input)
		{
			return 0U;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1810B20", Offset = "0x180FF20", VA = "0x181810B20")]
		public static bool IsValidWithCrcAtEnd(byte[] input, int offset, int lengthWithCrc)
		{
			return default(bool);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1810BB0", Offset = "0x180FFB0", VA = "0x181810BB0")]
		public static bool IsValidWithCrcAtEnd(byte[] input)
		{
			return default(bool);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1810280", Offset = "0x180F680", VA = "0x181810280")]
		private static uint AppendInternal(uint initial, byte[] input, int offset, int length)
		{
			return 0U;
		}

		// Token: 0x04000360 RID: 864
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x28")]
		private uint _currentCrc;

		// Token: 0x04000361 RID: 865
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SafeProxy _proxy;
	}
}
