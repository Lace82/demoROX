using System;
using System.IO;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	internal class ReceiveState
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public MemoryStream Stream
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x2B9AAA0", Offset = "0x2B99EA0", VA = "0x182B9AAA0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x2B9AA50", Offset = "0x2B99E50", VA = "0x182B9AA50")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x10")]
		private bool _bDisposed;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private MemoryStream <Stream>k__BackingField;
	}
}
