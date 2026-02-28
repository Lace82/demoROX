using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Il2CppDummyDll;

namespace GCloud.UQM.MiniJSON
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000C5")]
	public static class Json
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x2761290", Offset = "0x2760690", VA = "0x182761290")]
		public static object Deserialize(string json)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x27612A0", Offset = "0x27606A0", VA = "0x1827612A0")]
		public static string Serialize(object obj)
		{
			return null;
		}

		// Token: 0x020000F3 RID: 243
		[Token(Token = "0x2000161")]
		private sealed class Parser : IDisposable
		{
			// Token: 0x060008DC RID: 2268 RVA: 0x00003F78 File Offset: 0x00002178
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x2763FB0", Offset = "0x27633B0", VA = "0x182763FB0")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x2764B20", Offset = "0x2763F20", VA = "0x182764B20")]
			private Parser(string jsonString)
			{
			}

			// Token: 0x060008DE RID: 2270 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x2764A00", Offset = "0x2763E00", VA = "0x182764A00")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			// Token: 0x060008DF RID: 2271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x2763EB0", Offset = "0x27632B0", VA = "0x182763EB0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060008E0 RID: 2272 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x2764590", Offset = "0x2763990", VA = "0x182764590")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			// Token: 0x060008E1 RID: 2273 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x2764040", Offset = "0x2763440", VA = "0x182764040")]
			private List<object> ParseArray()
			{
				return null;
			}

			// Token: 0x060008E2 RID: 2274 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x27649D0", Offset = "0x2763DD0", VA = "0x1827649D0")]
			private object ParseValue()
			{
				return null;
			}

			// Token: 0x060008E3 RID: 2275 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x2764110", Offset = "0x2763510", VA = "0x182764110")]
			private object ParseByToken(Json.Parser.TOKEN token)
			{
				return null;
			}

			// Token: 0x060008E4 RID: 2276 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B5A")]
			[Address(RVA = "0x27646D0", Offset = "0x2763AD0", VA = "0x1827646D0")]
			private string ParseString()
			{
				return null;
			}

			// Token: 0x060008E5 RID: 2277 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0x27644A0", Offset = "0x27638A0", VA = "0x1827644A0")]
			private object ParseNumber()
			{
				return null;
			}

			// Token: 0x060008E6 RID: 2278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0x2763EF0", Offset = "0x27632F0", VA = "0x182763EF0")]
			private void EatWhitespace()
			{
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00003F90 File Offset: 0x00002190
			[Token(Token = "0x17000096")]
			private char PeekChar
			{
				[Token(Token = "0x6000B5D")]
				[Address(RVA = "0x2765040", Offset = "0x2764440", VA = "0x182765040")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00003FA8 File Offset: 0x000021A8
			[Token(Token = "0x17000097")]
			private char NextChar
			{
				[Token(Token = "0x6000B5E")]
				[Address(RVA = "0x2764BA0", Offset = "0x2763FA0", VA = "0x182764BA0")]
				get
				{
					return '\0';
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000098")]
			private string NextWord
			{
				[Token(Token = "0x6000B5F")]
				[Address(RVA = "0x2764F10", Offset = "0x2764310", VA = "0x182764F10")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x060008EA RID: 2282 RVA: 0x00003FC0 File Offset: 0x000021C0
			[Token(Token = "0x17000099")]
			private Json.Parser.TOKEN NextToken
			{
				[Token(Token = "0x6000B60")]
				[Address(RVA = "0x2764C20", Offset = "0x2764020", VA = "0x182764C20")]
				get
				{
					return Json.Parser.TOKEN.NONE;
				}
			}

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x400057D")]
			private const string WORD_BREAK = "{}[],:\"";

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x400057E")]
			[FieldOffset(Offset = "0x10")]
			private StringReader json;

			// Token: 0x020000F4 RID: 244
			[Token(Token = "0x200018C")]
			private enum TOKEN
			{
				// Token: 0x04000438 RID: 1080
				[Token(Token = "0x4000623")]
				NONE,
				// Token: 0x04000439 RID: 1081
				[Token(Token = "0x4000624")]
				CURLY_OPEN,
				// Token: 0x0400043A RID: 1082
				[Token(Token = "0x4000625")]
				CURLY_CLOSE,
				// Token: 0x0400043B RID: 1083
				[Token(Token = "0x4000626")]
				SQUARED_OPEN,
				// Token: 0x0400043C RID: 1084
				[Token(Token = "0x4000627")]
				SQUARED_CLOSE,
				// Token: 0x0400043D RID: 1085
				[Token(Token = "0x4000628")]
				COLON,
				// Token: 0x0400043E RID: 1086
				[Token(Token = "0x4000629")]
				COMMA,
				// Token: 0x0400043F RID: 1087
				[Token(Token = "0x400062A")]
				STRING,
				// Token: 0x04000440 RID: 1088
				[Token(Token = "0x400062B")]
				NUMBER,
				// Token: 0x04000441 RID: 1089
				[Token(Token = "0x400062C")]
				TRUE,
				// Token: 0x04000442 RID: 1090
				[Token(Token = "0x400062D")]
				FALSE,
				// Token: 0x04000443 RID: 1091
				[Token(Token = "0x400062E")]
				NULL
			}
		}

		// Token: 0x020000F5 RID: 245
		[Token(Token = "0x2000162")]
		private sealed class Serializer
		{
			// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x276FFB0", Offset = "0x276F3B0", VA = "0x18276FFB0")]
			private Serializer()
			{
			}

			// Token: 0x060008EC RID: 2284 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x27612A0", Offset = "0x27606A0", VA = "0x1827612A0")]
			public static string Serialize(object obj)
			{
				return null;
			}

			// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x276FDD0", Offset = "0x276F1D0", VA = "0x18276FDD0")]
			private void SerializeValue(object value)
			{
			}

			// Token: 0x060008EE RID: 2286 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x276F6C0", Offset = "0x276EAC0", VA = "0x18276F6C0")]
			private void SerializeObject(IDictionary obj)
			{
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B65")]
			[Address(RVA = "0x276F4D0", Offset = "0x276E8D0", VA = "0x18276F4D0")]
			private void SerializeArray(IList anArray)
			{
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x276FB60", Offset = "0x276EF60", VA = "0x18276FB60")]
			private void SerializeString(string str)
			{
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x276F940", Offset = "0x276ED40", VA = "0x18276F940")]
			private void SerializeOther(object value)
			{
			}

			// Token: 0x04000444 RID: 1092
			[Token(Token = "0x400057F")]
			[FieldOffset(Offset = "0x10")]
			private StringBuilder builder;
		}
	}
}
