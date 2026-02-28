using System;
using System.IO;
using Il2CppDummyDll;

namespace XGameFramework.Network
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	internal class SendState
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600027F RID: 639 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000065")]
		public MemoryStream Stream
		{
			[Token(Token = "0x600027E")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x2B9C080", Offset = "0x2B9B480", VA = "0x182B9C080", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x2B9AA50", Offset = "0x2B99E50", VA = "0x182B9AA50")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		private bool _bDisposed;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private MemoryStream <Stream>k__BackingField;
	}
}
