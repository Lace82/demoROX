using System;
using Il2CppDummyDll;

namespace XGameFramework.Utils
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public class Singleton<T> where T : class, new()
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000048")]
		public static T Instance
		{
			[Token(Token = "0x60001B4")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60001B5")]
		public static T GetInstance()
		{
			return null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B6")]
		public void Dispose()
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B7")]
		private static void CreateInstance()
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B8")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001B9")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001BA")]
		public Singleton()
		{
		}

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x0")]
		private static T _instance;
	}
}
