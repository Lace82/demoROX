using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x20000FA")]
	public class InnerLangConfig
	{
		// Token: 0x06000A21 RID: 2593 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xEC1E20", Offset = "0xEC1220", VA = "0x180EC1E20")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xDAC20", Offset = "0xDA020")]
		private static UniTask SyncInnerConfig()
		{
			return default(UniTask);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xEC1D50", Offset = "0xEC1150", VA = "0x180EC1D50")]
		public static UniTask Init()
		{
			return default(UniTask);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public InnerLangConfig()
		{
		}

		// Token: 0x040005BB RID: 1467
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x50230")]
		public static readonly List<LanguageList> LANG_LIST;

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x400046D")]
		private const string INNER_LANG_CONFIG_PATH = "config/innerlang/{0}/innerlang.cfg";
	}
}
