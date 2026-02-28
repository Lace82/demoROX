using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200004A")]
	internal class DependAssetBundles
	{
		// Token: 0x060001E3 RID: 483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x104A180", Offset = "0x1049580", VA = "0x18104A180")]
		public DependAssetBundles(List<BundleLoaderBase> dpendList)
		{
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1812B40", Offset = "0x1811F40", VA = "0x181812B40")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1812CA0", Offset = "0x18120A0", VA = "0x181812CA0")]
		public bool IsSucceed()
		{
			return default(bool);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x18129D0", Offset = "0x1811DD0", VA = "0x1818129D0")]
		public string GetLastError()
		{
			return null;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1812FE0", Offset = "0x18123E0", VA = "0x181812FE0")]
		public void WaitForAsyncComplete()
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1812E00", Offset = "0x1812200", VA = "0x181812E00")]
		public void Reference()
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1812EF0", Offset = "0x18122F0", VA = "0x181812EF0")]
		public void Release()
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1812830", Offset = "0x1811C30", VA = "0x181812830")]
		internal void GetBundleDebugInfos(List<DebugBundleInfo> output)
		{
		}

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		internal readonly List<BundleLoaderBase> DependList;
	}
}
