using System;
using System.IO;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace SDK
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x2000061")]
	public class PlistDocument
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1382540", Offset = "0x1381940", VA = "0x181382540")]
		public PlistDocument()
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x13814B0", Offset = "0x13808B0", VA = "0x1813814B0")]
		internal static XDocument ParseXmlNoDtd(string text)
		{
			return null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1380D80", Offset = "0x1380180", VA = "0x181380D80")]
		internal static string CleanDtdToString(XDocument doc)
		{
			return null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1381360", Offset = "0x1380760", VA = "0x181381360")]
		private static string GetText(XElement xml)
		{
			return null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1381590", Offset = "0x1380990", VA = "0x181381590")]
		private static PlistElement ReadElement(XElement xml)
		{
			return null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1381320", Offset = "0x1380720", VA = "0x181381320")]
		public void Create()
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1381A40", Offset = "0x1380E40", VA = "0x181381A40")]
		public void ReadFromFile(string path)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1381A70", Offset = "0x1380E70", VA = "0x181381A70")]
		public void ReadFromStream(TextReader tr)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1381AB0", Offset = "0x1380EB0", VA = "0x181381AB0")]
		public void ReadFromString(string text)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1381CE0", Offset = "0x13810E0", VA = "0x181381CE0")]
		private static XElement WriteElement(PlistElement el)
		{
			return null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1382330", Offset = "0x1381730", VA = "0x181382330")]
		public void WriteToFile(string path)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x13823B0", Offset = "0x13817B0", VA = "0x1813823B0")]
		public void WriteToStream(TextWriter tw)
		{
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x13823F0", Offset = "0x13817F0", VA = "0x1813823F0")]
		public string WriteToString()
		{
			return null;
		}

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x10")]
		public PlistElementDict root;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x18")]
		public string version;

		// Token: 0x0200008B RID: 139
		[Token(Token = "0x200015D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
			public <>c()
			{
			}

			// Token: 0x06000472 RID: 1138 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x138E630", Offset = "0x138DA30", VA = "0x18138E630")]
			internal string <GetText>b__5_0(XText x)
			{
				return null;
			}

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000570")]
			[FieldOffset(Offset = "0x0")]
			public static readonly PlistDocument.<>c <>9;

			// Token: 0x0400029A RID: 666
			[Token(Token = "0x4000571")]
			[FieldOffset(Offset = "0x8")]
			public static Func<XText, string> <>9__5_0;
		}
	}
}
