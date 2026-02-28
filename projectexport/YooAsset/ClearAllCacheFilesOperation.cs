using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000007")]
	public sealed class ClearAllCacheFilesOperation : AsyncOperationBase
	{
		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1811CB0", Offset = "0x18110B0", VA = "0x181811CB0")]
		internal ClearAllCacheFilesOperation(CacheManager cache)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1811AE0", Offset = "0x1810EE0", VA = "0x181811AE0", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1811AF0", Offset = "0x1810EF0", VA = "0x181811AF0", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x48")]
		private readonly CacheManager _cache;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x50")]
		private List<string> _allCacheGUIDs;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x58")]
		private int _fileTotalCount;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x5C")]
		private ClearAllCacheFilesOperation.ESteps _steps;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x20000AB")]
		private enum ESteps
		{
			// Token: 0x0400001D RID: 29
			[Token(Token = "0x4000269")]
			None,
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400026A")]
			GetAllCacheFiles,
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400026B")]
			ClearAllCacheFiles,
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x400026C")]
			Done
		}
	}
}
