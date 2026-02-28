using System;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public static class JsonUtility
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public static JsonUtility.IJsonHelper JsonHelper
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2B974A0", Offset = "0x2B968A0", VA = "0x182B974A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x2B974E0", Offset = "0x2B968E0", VA = "0x182B974E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2B97100", Offset = "0x2B96500", VA = "0x182B97100")]
		public static void SetJsonHelper(JsonUtility.IJsonHelper jsonHelper)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2B97150", Offset = "0x2B96550", VA = "0x182B97150")]
		public static string ToJson(object obj)
		{
			return null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000167")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2B972F0", Offset = "0x2B966F0", VA = "0x182B972F0")]
		public static object ToObject(Type objectType, string json)
		{
			return null;
		}

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x743CE")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static JsonUtility.IJsonHelper <JsonHelper>k__BackingField;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public interface IJsonHelper
		{
			// Token: 0x06000169 RID: 361
			[Token(Token = "0x6000169")]
			string ToJson(object obj);

			// Token: 0x0600016A RID: 362
			[Token(Token = "0x600016A")]
			T ToObject<T>(string json);

			// Token: 0x0600016B RID: 363
			[Token(Token = "0x600016B")]
			object ToObject(Type objectType, string json);
		}
	}
}
