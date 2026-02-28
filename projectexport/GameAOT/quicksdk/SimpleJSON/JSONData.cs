using System;
using System.IO;
using Il2CppDummyDll;

namespace quicksdk.SimpleJSON
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000058")]
	public class JSONData : JSONNode
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003F")]
		public override string Value
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public JSONData(string aData)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x388D5D0", Offset = "0x388C9D0", VA = "0x18388D5D0")]
		public JSONData(float aData)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x388D650", Offset = "0x388CA50", VA = "0x18388D650")]
		public JSONData(double aData)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x388D690", Offset = "0x388CA90", VA = "0x18388D690")]
		public JSONData(bool aData)
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x388D610", Offset = "0x388CA10", VA = "0x18388D610")]
		public JSONData(int aData)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x388D580", Offset = "0x388C980", VA = "0x18388D580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x388D530", Offset = "0x388C930", VA = "0x18388D530", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x388D210", Offset = "0x388C610", VA = "0x18388D210", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		// Token: 0x0400028F RID: 655
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x10")]
		private string m_Data;
	}
}
