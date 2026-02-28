using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public static class PoolUtils
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002144 File Offset: 0x00000344
		[Token(Token = "0x6000038")]
		public static PoolUtils.HashSetProvider<T> ProvideHashSet<T>()
		{
			return default(PoolUtils.HashSetProvider<T>);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000039")]
		public static PoolUtils.ListProvider<T> ProvideList<T>()
		{
			return default(PoolUtils.ListProvider<T>);
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public readonly struct HashSetProvider<T> : IDisposable
		{
			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000012")]
			public HashSet<T> Set
			{
				[Token(Token = "0x600003A")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003B")]
			public HashSetProvider(HashSet<T> set)
			{
			}

			// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003C")]
			public void Dispose()
			{
			}

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private readonly HashSet<T> <Set>k__BackingField;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public readonly struct ListProvider<T> : IDisposable
		{
			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600003D RID: 61 RVA: 0x00002068 File Offset: 0x00000268
			[Token(Token = "0x17000013")]
			public List<T> List
			{
				[Token(Token = "0x600003D")]
				[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600003E RID: 62 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003E")]
			public ListProvider(List<T> list)
			{
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600003F")]
			public void Dispose()
			{
			}

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[FieldOffset(Offset = "0x0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private readonly List<T> <List>k__BackingField;
		}
	}
}
