using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public class DownloadAgentHelperErrorEventArgs : XGameFrameworkEventArgs
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x2B8FBE0", Offset = "0x2B8EFE0", VA = "0x182B8FBE0")]
		public DownloadAgentHelperErrorEventArgs()
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00002EC4 File Offset: 0x000010C4
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000086")]
		public bool DeleteDownloading
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0xDFD690", Offset = "0xDFCA90", VA = "0x180DFD690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000368")]
			[Address(RVA = "0xEC9E00", Offset = "0xEC9200", VA = "0x180EC9E00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000369 RID: 873 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000087")]
		public string ErrorMessage
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600036A")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x2B8FB50", Offset = "0x2B8EF50", VA = "0x182B8FB50")]
		public static DownloadAgentHelperErrorEventArgs Create(bool deleteDownloading, string errorMessage)
		{
			return null;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x2B8FB30", Offset = "0x2B8EF30", VA = "0x182B8FB30", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <DeleteDownloading>k__BackingField;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <ErrorMessage>k__BackingField;
	}
}
