using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x2000008")]
	public sealed class ClearUnusedCacheFilesOperation : AsyncOperationBase
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1812030", Offset = "0x1811430", VA = "0x181812030")]
		internal ClearUnusedCacheFilesOperation(ResourcePackage package, CacheManager cache)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1811E60", Offset = "0x1811260", VA = "0x181811E60", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1811E70", Offset = "0x1811270", VA = "0x181811E70", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1811CE0", Offset = "0x18110E0", VA = "0x181811CE0")]
		private List<string> GetUnusedCacheGUIDs()
		{
			return null;
		}

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x48")]
		private readonly ResourcePackage _package;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x50")]
		private readonly CacheManager _cache;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x58")]
		private List<string> _unusedCacheGUIDs;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x60")]
		private int _unusedFileTotalCount;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x64")]
		private ClearUnusedCacheFilesOperation.ESteps _steps;

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x20000AC")]
		private enum ESteps
		{
			// Token: 0x04000027 RID: 39
			[Token(Token = "0x400026E")]
			None,
			// Token: 0x04000028 RID: 40
			[Token(Token = "0x400026F")]
			GetUnusedCacheFiles,
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000270")]
			ClearUnusedCacheFiles,
			// Token: 0x0400002A RID: 42
			[Token(Token = "0x4000271")]
			Done
		}
	}
}
