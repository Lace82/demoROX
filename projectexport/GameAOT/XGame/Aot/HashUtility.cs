using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using UnityEngine;

namespace XGame.Aot
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200010A")]
	public static class HashUtility
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000960")]
		[Address(RVA = "0xEC13B0", Offset = "0xEC07B0", VA = "0x180EC13B0")]
		private static void GetRawBytes(Stack<object> state, Stream stream)
		{
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000961")]
		[Address(RVA = "0xEC1310", Offset = "0xEC0710", VA = "0x180EC1310")]
		private static void GetRawBytes(Stream stream, object obj)
		{
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000962")]
		[Address(RVA = "0xEC1210", Offset = "0xEC0610", VA = "0x180EC1210")]
		private static HashAlgorithm GetHashAlgorithm(Type type)
		{
			return null;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000963")]
		[Address(RVA = "0xEC0E80", Offset = "0xEC0280", VA = "0x180EC0E80")]
		public static HashUtility.RawHash CalculateStream(Stream stream)
		{
			return default(HashUtility.RawHash);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000964")]
		[Address(RVA = "0xEC10B0", Offset = "0xEC04B0", VA = "0x180EC10B0")]
		public static HashUtility.RawHash Calculate(object obj)
		{
			return default(HashUtility.RawHash);
		}

		// Token: 0x0200015F RID: 351
		[Token(Token = "0x2000187")]
		[Serializable]
		public struct RawHash : IEquatable<HashUtility.RawHash>
		{
			// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000BB0")]
			[Address(RVA = "0xECE040", Offset = "0xECD440", VA = "0x180ECE040")]
			internal RawHash(byte[] hash)
			{
			}

			// Token: 0x06000AA2 RID: 2722 RVA: 0x000045F0 File Offset: 0x000027F0
			[Token(Token = "0x6000BB1")]
			[Address(RVA = "0xECDFF0", Offset = "0xECD3F0", VA = "0x180ECDFF0")]
			internal static HashUtility.RawHash Zero()
			{
				return default(HashUtility.RawHash);
			}

			// Token: 0x06000AA3 RID: 2723 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000BB2")]
			[Address(RVA = "0xCA9D60", Offset = "0xCA9160", VA = "0x180CA9D60")]
			public byte[] ToBytes()
			{
				return null;
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x00004608 File Offset: 0x00002808
			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0xECDE40", Offset = "0xECD240", VA = "0x180ECDE40")]
			public Hash128 ToHash128()
			{
				return default(Hash128);
			}

			// Token: 0x06000AA5 RID: 2725 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0xECDF50", Offset = "0xECD350", VA = "0x180ECDF50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06000AA6 RID: 2726 RVA: 0x00004620 File Offset: 0x00002820
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0xECDD20", Offset = "0xECD120", VA = "0x180ECDD20", Slot = "4")]
			public bool Equals(HashUtility.RawHash other)
			{
				return default(bool);
			}

			// Token: 0x06000AA7 RID: 2727 RVA: 0x00004638 File Offset: 0x00002838
			[Token(Token = "0x6000BB6")]
			[Address(RVA = "0xECDD70", Offset = "0xECD170", VA = "0x180ECDD70", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06000AA8 RID: 2728 RVA: 0x00004650 File Offset: 0x00002850
			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0xECDE20", Offset = "0xECD220", VA = "0x180ECDE20", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x04000614 RID: 1556
			[Token(Token = "0x4000615")]
			[FieldOffset(Offset = "0x0")]
			private readonly byte[] _hash;
		}
	}
}
