using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x2000009")]
	internal sealed class FindCacheFilesOperation : AsyncOperationBase
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x181A4A0", Offset = "0x18198A0", VA = "0x18181A4A0")]
		public FindCacheFilesOperation(PersistentManager persistent, CacheManager cache)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1819F30", Offset = "0x1819330", VA = "0x181819F30", Slot = "8")]
		internal override void InternalOnStart()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1819F60", Offset = "0x1819360", VA = "0x181819F60", Slot = "9")]
		internal override void InternalOnUpdate()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x181A0D0", Offset = "0x18194D0", VA = "0x18181A0D0")]
		private bool UpdateCacheFiles()
		{
			return default(bool);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1819E30", Offset = "0x1819230", VA = "0x181819E30")]
		private string FindDataFileExtension(DirectoryInfo directoryInfo)
		{
			return null;
		}

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x48")]
		private readonly PersistentManager _persistent;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x50")]
		private readonly CacheManager _cache;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x58")]
		private IEnumerator<DirectoryInfo> _filesEnumerator;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x60")]
		private float _verifyStartTime;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x64")]
		private FindCacheFilesOperation.ESteps _steps;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x68")]
		public readonly List<VerifyCacheFileElement> VerifyElements;

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x20000AD")]
		private enum ESteps
		{
			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000273")]
			None,
			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000274")]
			Prepare,
			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000275")]
			UpdateCacheFiles,
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000276")]
			Done
		}
	}
}
