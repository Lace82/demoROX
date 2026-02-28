using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public sealed class DownloadAgentHelperUpdateBytesEventArgs : XGameFrameworkEventArgs
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00002EDC File Offset: 0x000010DC
		// (set) Token: 0x0600036E RID: 878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000088")]
		public int Offset
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0xB9A920", Offset = "0xB99D20", VA = "0x180B9A920")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x1238580", Offset = "0x1237980", VA = "0x181238580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00002EF4 File Offset: 0x000010F4
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000089")]
		public int Length
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x1238560", Offset = "0x1237960", VA = "0x181238560")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1238570", Offset = "0x1237970", VA = "0x181238570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x2B8FDE0", Offset = "0x2B8F1E0", VA = "0x182B8FDE0")]
		public DownloadAgentHelperUpdateBytesEventArgs()
		{
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x2B8FC80", Offset = "0x2B8F080", VA = "0x182B8FC80")]
		public static DownloadAgentHelperUpdateBytesEventArgs Create(byte[] bytes, int offset, int length)
		{
			return null;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x2B8FC50", Offset = "0x2B8F050", VA = "0x182B8FC50", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		private byte[] _byteArray;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <Offset>k__BackingField;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x1C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <Length>k__BackingField;
	}
}
