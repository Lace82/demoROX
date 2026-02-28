using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YooAsset
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000049")]
	internal abstract class BundleLoaderBase
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001C2 RID: 450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public ResourceManager Impl
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xCC26A0", Offset = "0xCC1AA0", VA = "0x180CC26A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000048")]
		public BundleInfo MainBundleInfo
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000049")]
		public int RefCount
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0xCC2F30", Offset = "0xCC2330", VA = "0x180CC2F30")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x123B510", Offset = "0x123A910", VA = "0x18123B510")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004A")]
		public BundleLoaderBase.EStatus Status
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0xCC2F20", Offset = "0xCC2320", VA = "0x180CC2F20")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return BundleLoaderBase.EStatus.None;
			}
			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x10481A0", Offset = "0x10475A0", VA = "0x1810481A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004B")]
		public string LastError
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xB9A940", Offset = "0xB99D40", VA = "0x180B9A940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xCC1D90", Offset = "0xCC1190", VA = "0x180CC1D90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004C")]
		public bool IsDestroyed
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0xEC9DE0", Offset = "0xEC91E0", VA = "0x180EC9DE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0xEC9DF0", Offset = "0xEC91F0", VA = "0x180EC9DF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001CF RID: 463 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004D")]
		private protected bool IsForceDestroyComplete
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xB9D470", Offset = "0xB9C870", VA = "0x180B9D470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xB9D940", Offset = "0xB9CD40", VA = "0x180B9D940")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004E")]
		internal AssetBundle CacheBundle
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xCB8250", Offset = "0xCB7650", VA = "0x180CB8250")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x105D290", Offset = "0x105C690", VA = "0x18105D290")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700004F")]
		internal string FileLoadPath
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xCB09B0", Offset = "0xCAFDB0", VA = "0x180CB09B0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xCB1390", Offset = "0xCB0790", VA = "0x180CB1390")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002730 File Offset: 0x00000930
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		internal float DownloadProgress
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x180EBA0", Offset = "0x180DFA0", VA = "0x18180EBA0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x180EBB0", Offset = "0x180DFB0", VA = "0x18180EBB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00002748 File Offset: 0x00000948
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000051")]
		internal ulong DownloadedBytes
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xCB0840", Offset = "0xCAFC40", VA = "0x180CB0840")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return 0UL;
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x17303D0", Offset = "0x172F7D0", VA = "0x1817303D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			set
			{
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x180EAC0", Offset = "0x180DEC0", VA = "0x18180EAC0")]
		public BundleLoaderBase(ResourceManager impl, BundleInfo bundleInfo)
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x180E900", Offset = "0x180DD00", VA = "0x18180E900")]
		public void Reference()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x180E910", Offset = "0x180DD10", VA = "0x18180E910")]
		public void Release()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x180E8F0", Offset = "0x180DCF0", VA = "0x18180E8F0")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x180E710", Offset = "0x180DB10", VA = "0x18180E710")]
		public bool CanDestroy()
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x180E6A0", Offset = "0x180DAA0", VA = "0x18180E6A0")]
		public void AddProvider(ProviderBase provider)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x180E920", Offset = "0x180DD20", VA = "0x18180E920")]
		public void TryDestroyProviders()
		{
		}

		// Token: 0x060001DF RID: 479
		[Token(Token = "0x60001D4")]
		public abstract void Update();

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x180E730", Offset = "0x180DB30", VA = "0x18180E730", Slot = "5")]
		public virtual void Destroy()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x180E8D0", Offset = "0x180DCD0", VA = "0x18180E8D0")]
		public void ForceDestroyComplete()
		{
		}

		// Token: 0x060001E2 RID: 482
		[Token(Token = "0x60001D7")]
		public abstract void WaitForAsyncComplete();

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ResourceManager <Impl>k__BackingField;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private BundleInfo <MainBundleInfo>k__BackingField;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private int <RefCount>k__BackingField;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x24")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private BundleLoaderBase.EStatus <Status>k__BackingField;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <LastError>k__BackingField;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsDestroyed>k__BackingField;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<ProviderBase> _providers;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<ProviderBase> _removeList;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private bool <IsForceDestroyComplete>k__BackingField;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private AssetBundle <CacheBundle>k__BackingField;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private string <FileLoadPath>k__BackingField;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400010A")]
		[FieldOffset(Offset = "0x60")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private float <DownloadProgress>k__BackingField;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ulong <DownloadedBytes>k__BackingField;

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x20000B9")]
		public enum EStatus
		{
			// Token: 0x0400015F RID: 351
			[Token(Token = "0x40002B7")]
			None,
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x40002B8")]
			Succeed,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x40002B9")]
			Failed
		}
	}
}
