using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace CrashSightSDKEditor.XUPorterJSON
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000C6")]
	public class MiniJSON
	{
		// Token: 0x060008F2 RID: 2290 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x2761C50", Offset = "0x2761050", VA = "0x182761C50")]
		public static object jsonDecode(string json)
		{
			return null;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2761DA0", Offset = "0x27611A0", VA = "0x182761DA0")]
		public static string jsonEncode(object json)
		{
			return null;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2761E50", Offset = "0x2761250", VA = "0x182761E50")]
		public static bool lastDecodeSuccessful()
		{
			return default(bool);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x27619E0", Offset = "0x2760DE0", VA = "0x1827619E0")]
		public static int getLastErrorIndex()
		{
			return 0;
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2761A40", Offset = "0x2760E40", VA = "0x182761A40")]
		public static string getLastErrorSnippet()
		{
			return null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x2762680", Offset = "0x2761A80", VA = "0x182762680")]
		protected static Hashtable parseObject(char[] json, ref int index)
		{
			return null;
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2762340", Offset = "0x2761740", VA = "0x182762340")]
		protected static ArrayList parseArray(char[] json, ref int index)
		{
			return null;
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2762BC0", Offset = "0x2761FC0", VA = "0x182762BC0")]
		protected static object parseValue(char[] json, ref int index, ref bool success)
		{
			return null;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2762860", Offset = "0x2761C60", VA = "0x182762860")]
		protected static string parseString(char[] json, ref int index)
		{
			return null;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x27624B0", Offset = "0x27618B0", VA = "0x1827624B0")]
		protected static double parseNumber(char[] json, ref int index)
		{
			return 0.0;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2761BB0", Offset = "0x2760FB0", VA = "0x182761BB0")]
		protected static int getLastIndexOfNumber(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2761950", Offset = "0x2760D50", VA = "0x182761950")]
		protected static void eatWhitespace(char[] json, ref int index)
		{
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2761EB0", Offset = "0x27612B0", VA = "0x182761EB0")]
		protected static int lookAhead(char[] json, int index)
		{
			return 0;
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x2761F20", Offset = "0x2761320", VA = "0x182761F20")]
		protected static int nextToken(char[] json, ref int index)
		{
			return 0;
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2763230", Offset = "0x2762630", VA = "0x182763230")]
		protected static bool serializeObjectOrArray(object objectOrArray, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x27633A0", Offset = "0x27627A0", VA = "0x1827633A0")]
		protected static bool serializeObject(Hashtable anObject, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x2762FF0", Offset = "0x27623F0", VA = "0x182762FF0")]
		protected static bool serializeDictionary(Dictionary<string, string> dict, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2762EB0", Offset = "0x27622B0", VA = "0x182762EB0")]
		protected static bool serializeArray(ArrayList anArray, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2763760", Offset = "0x2762B60", VA = "0x182763760")]
		protected static bool serializeValue(object value, StringBuilder builder)
		{
			return default(bool);
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x2763530", Offset = "0x2762930", VA = "0x182763530")]
		protected static void serializeString(string aString, StringBuilder builder)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x27631B0", Offset = "0x27625B0", VA = "0x1827631B0")]
		protected static void serializeNumber(double number, StringBuilder builder)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public MiniJSON()
		{
		}

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000372")]
		private const int TOKEN_NONE = 0;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000373")]
		private const int TOKEN_CURLY_OPEN = 1;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000374")]
		private const int TOKEN_CURLY_CLOSE = 2;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000375")]
		private const int TOKEN_SQUARED_OPEN = 3;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000376")]
		private const int TOKEN_SQUARED_CLOSE = 4;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x4000377")]
		private const int TOKEN_COLON = 5;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x4000378")]
		private const int TOKEN_COMMA = 6;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x4000379")]
		private const int TOKEN_STRING = 7;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400037A")]
		private const int TOKEN_NUMBER = 8;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400037B")]
		private const int TOKEN_TRUE = 9;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400037C")]
		private const int TOKEN_FALSE = 10;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x400037D")]
		private const int TOKEN_NULL = 11;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x400037E")]
		private const int BUILDER_CAPACITY = 2000;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x400037F")]
		[FieldOffset(Offset = "0x0")]
		protected static int lastErrorIndex;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000380")]
		[FieldOffset(Offset = "0x8")]
		protected static string lastDecode;
	}
}
