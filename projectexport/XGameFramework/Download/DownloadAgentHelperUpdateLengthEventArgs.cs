using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public sealed class DownloadAgentHelperUpdateLengthEventArgs : XGameFrameworkEventArgs
	{
		// Token: 0x06000375 RID: 885 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x2B8FAD0", Offset = "0x2B8EED0", VA = "0x182B8FAD0")]
		public DownloadAgentHelperUpdateLengthEventArgs()
		{
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00002F0C File Offset: 0x0000110C
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008A")]
		public int DeltaLength
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x943540", Offset = "0x942940", VA = "0x180943540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x2B8FE50", Offset = "0x2B8F250", VA = "0x182B8FE50")]
		public static DownloadAgentHelperUpdateLengthEventArgs Create(int deltaLength)
		{
			return null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x2108E60", Offset = "0x2108260", VA = "0x182108E60", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <DeltaLength>k__BackingField;
	}
}
