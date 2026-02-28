using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace XGame.Aot
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x20000FF")]
	public class UpdateLangUtil
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x6000910")]
		[Address(RVA = "0xED8B40", Offset = "0xED7F40", VA = "0x180ED8B40")]
		[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xDCD00", Offset = "0xDC100")]
		public static UniTask Init()
		{
			return default(UniTask);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0xED8960", Offset = "0xED7D60", VA = "0x180ED8960")]
		private static void InitLangMap()
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000912")]
		[Address(RVA = "0xED85C0", Offset = "0xED79C0", VA = "0x180ED85C0")]
		public static string GetCurrentLangKey()
		{
			return null;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000913")]
		[Address(RVA = "0xED8640", Offset = "0xED7A40", VA = "0x180ED8640")]
		private static Dictionary<string, string> GetLangMap(int langType)
		{
			return null;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000914")]
		[Address(RVA = "0xED8750", Offset = "0xED7B50", VA = "0x180ED8750")]
		public static string GetString(string langId)
		{
			return null;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000915")]
		[Address(RVA = "0xED8830", Offset = "0xED7C30", VA = "0x180ED8830")]
		public static string GetString(string src, params object[] args)
		{
			return null;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public UpdateLangUtil()
		{
		}

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x400048D")]
		[FieldOffset(Offset = "0x4678148")]
		private static readonly Dictionary<int, Dictionary<string, string>> MLanguageMap;
	}
}
