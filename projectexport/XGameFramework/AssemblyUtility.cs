using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace XGameFramework
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	public static class AssemblyUtility
	{
		// Token: 0x06000106 RID: 262 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2B8C980", Offset = "0x2B8BD80", VA = "0x182B8C980")]
		public static Assembly[] GetAssemblies()
		{
			return null;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2B8CCA0", Offset = "0x2B8C0A0", VA = "0x182B8CCA0")]
		public static Type[] GetTypes(string assemblyName)
		{
			return null;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2B8CF10", Offset = "0x2B8C310", VA = "0x182B8CF10")]
		public static Type[] GetTypes()
		{
			return null;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2B8CE00", Offset = "0x2B8C200", VA = "0x182B8CE00")]
		public static void GetTypes(List<Type> list)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2B8C9E0", Offset = "0x2B8BDE0", VA = "0x182B8C9E0")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Assembly[] _assemblies;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Type> _cacheTypes;
	}
}
