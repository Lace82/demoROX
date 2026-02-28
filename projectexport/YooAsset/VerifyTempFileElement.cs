using System;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x2000014")]
	internal class VerifyTempFileElement
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		public string TempDataFilePath
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		public string FileCRC
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000021A8 File Offset: 0x000003A8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public long FileSize
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xB9A960", Offset = "0xB99D60", VA = "0x180B9A960")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x1237750", Offset = "0x1236B50", VA = "0x181237750")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1A48C30", Offset = "0x1A48030", VA = "0x181A48C30")]
		public VerifyTempFileElement(string tempDataFilePath, string fileCRC, long fileSize)
		{
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <TempDataFilePath>k__BackingField;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <FileCRC>k__BackingField;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private long <FileSize>k__BackingField;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x28")]
		public int Result;
	}
}
