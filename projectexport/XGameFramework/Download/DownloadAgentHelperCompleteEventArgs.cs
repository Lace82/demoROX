using System;
using Il2CppDummyDll;

namespace XGameFramework.Download
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	public class DownloadAgentHelperCompleteEventArgs : XGameFrameworkEventArgs
	{
		// Token: 0x06000361 RID: 865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x2B8FAD0", Offset = "0x2B8EED0", VA = "0x182B8FAD0")]
		public DownloadAgentHelperCompleteEventArgs()
		{
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00002EAC File Offset: 0x000010AC
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000085")]
		public int Length
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x8F5450", Offset = "0x8F4850", VA = "0x1808F5450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x943540", Offset = "0x942940", VA = "0x180943540")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x2B8FA30", Offset = "0x2B8EE30", VA = "0x182B8FA30")]
		public static DownloadAgentHelperCompleteEventArgs Create(int length)
		{
			return null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x2108E60", Offset = "0x2108260", VA = "0x182108E60", Slot = "5")]
		public override void Clear()
		{
		}

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <Length>k__BackingField;
	}
}
