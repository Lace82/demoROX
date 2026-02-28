using System;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x2000040")]
	internal class OperationSystem
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002598 File Offset: 0x00000798
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000036")]
		public static long MaxTimeSlice
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x1BAB3B0", Offset = "0x1BAA7B0", VA = "0x181BAB3B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x1BAB410", Offset = "0x1BAA810", VA = "0x181BAB410")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x17000037")]
		public static bool IsBusy
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x1BAB2C0", Offset = "0x1BAA6C0", VA = "0x181BAB2C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1BAABC0", Offset = "0x1BA9FC0", VA = "0x181BAABC0")]
		public static void Initialize()
		{
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1BAAD80", Offset = "0x1BAA180", VA = "0x181BAAD80")]
		public static void Update()
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1BAAA90", Offset = "0x1BA9E90", VA = "0x181BAAA90")]
		public static void DestroyAll()
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1BAA820", Offset = "0x1BA9C20", VA = "0x181BAA820")]
		public static void ClearPackageOperation(string packageName)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1BAACE0", Offset = "0x1BAA0E0", VA = "0x181BAACE0")]
		public static void StartOperation(string packageName, AsyncOperationBase operation)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1BAAC50", Offset = "0x1BAA050", VA = "0x181BAAC50")]
		public static void StartOperation(AsyncOperationBase operation)
		{
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x9413E0", Offset = "0x9407E0", VA = "0x1809413E0")]
		public OperationSystem()
		{
		}

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<AsyncOperationBase> _operations;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<AsyncOperationBase> _newList;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x10")]
		private static Stopwatch _watch;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x18")]
		private static long _frameTime;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private static long <MaxTimeSlice>k__BackingField;
	}
}
