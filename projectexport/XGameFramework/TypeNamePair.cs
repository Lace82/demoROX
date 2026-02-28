using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[StructLayout(LayoutKind.Auto)]
	public readonly struct TypeNamePair : IEquatable<TypeNamePair>
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000031")]
		public string Name
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xCA9D60", Offset = "0xCA9160", VA = "0x180CA9D60")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000032")]
		public Type Type
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x11AB190", Offset = "0x11AA590", VA = "0x1811AB190")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2B9E410", Offset = "0x2B9D810", VA = "0x182B9E410")]
		public TypeNamePair(Type type)
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2B9E470", Offset = "0x2B9D870", VA = "0x182B9E470")]
		public TypeNamePair(Type type, string name)
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2B9E2B0", Offset = "0x2B9D6B0", VA = "0x182B9E2B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2B9E310", Offset = "0x2B9D710", VA = "0x182B9E310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2B9E220", Offset = "0x2B9D620", VA = "0x182B9E220", Slot = "4")]
		public bool Equals(TypeNamePair value)
		{
			return default(bool);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2B9E120", Offset = "0x2B9D520", VA = "0x182B9E120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2B9E530", Offset = "0x2B9D930", VA = "0x182B9E530")]
		public static bool operator ==(TypeNamePair a, TypeNamePair b)
		{
			return default(bool);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2B9E5C0", Offset = "0x2B9D9C0", VA = "0x182B9E5C0")]
		public static bool operator !=(TypeNamePair a, TypeNamePair b)
		{
			return default(bool);
		}

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly string <Name>k__BackingField;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private readonly Type <Type>k__BackingField;
	}
}
