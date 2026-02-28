using System;
using System.IO;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x200009F")]
	internal class BufferWriter
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x180D970", Offset = "0x180CD70", VA = "0x18180D970")]
		public BufferWriter(int capacity)
		{
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x170000A2")]
		public int Capacity
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x13D1840", Offset = "0x13D0C40", VA = "0x1813D1840")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x180CE50", Offset = "0x180C250", VA = "0x18180CE50")]
		public void Clear()
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x180D3E0", Offset = "0x180C7E0", VA = "0x18180D3E0")]
		public void WriteToStream(FileStream fileStream)
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x180CEF0", Offset = "0x180C2F0", VA = "0x18180CEF0")]
		public void WriteBytes(byte[] data)
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x180CEB0", Offset = "0x180C2B0", VA = "0x18180CEB0")]
		public void WriteByte(byte value)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x180CE60", Offset = "0x180C260", VA = "0x18180CE60")]
		public void WriteBool(bool value)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x180CF40", Offset = "0x180C340", VA = "0x18180CF40")]
		public void WriteInt16(short value)
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x180D420", Offset = "0x180C820", VA = "0x18180D420")]
		public void WriteUInt16(ushort value)
		{
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x180D190", Offset = "0x180C590", VA = "0x18180D190")]
		public void WriteInt32(int value)
		{
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x180D190", Offset = "0x180C590", VA = "0x18180D190")]
		public void WriteUInt32(uint value)
		{
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x180D3D0", Offset = "0x180C7D0", VA = "0x18180D3D0")]
		public void WriteInt64(long value)
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x180D4A0", Offset = "0x180C8A0", VA = "0x18180D4A0")]
		public void WriteUInt64(ulong value)
		{
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x180D800", Offset = "0x180CC00", VA = "0x18180D800")]
		public void WriteUTF8(string value)
		{
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x180CF50", Offset = "0x180C350", VA = "0x18180CF50")]
		public void WriteInt32Array(int[] values)
		{
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x180D270", Offset = "0x180C670", VA = "0x18180D270")]
		public void WriteInt64Array(long[] values)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x180D6A0", Offset = "0x180CAA0", VA = "0x18180D6A0")]
		public void WriteUTF8Array(string[] values)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x180CDD0", Offset = "0x180C1D0", VA = "0x18180CDD0")]
		[Attribute(Name = "ConditionalAttribute", RVA = "0x8FAD0", Offset = "0x8EED0")]
		private void CheckWriterIndex(int length)
		{
		}

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] _buffer;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		private int _index;
	}
}
