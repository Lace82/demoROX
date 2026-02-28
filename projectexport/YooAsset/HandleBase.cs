using System;
using System.Collections;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace YooAsset
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000043")]
	public abstract class HandleBase : IEnumerator
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		internal ProviderBase Provider
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xB9D930", Offset = "0xB9CD30", VA = "0x180B9D930")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
			private set
			{
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1808DB0", Offset = "0x18081B0", VA = "0x181808DB0")]
		internal HandleBase(ProviderBase provider)
		{
		}

		// Token: 0x0600018C RID: 396
		[Token(Token = "0x6000181")]
		internal abstract void InvokeCallback();

		// Token: 0x0600018D RID: 397 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB9A930", Offset = "0xB99D30", VA = "0x180B9A930")]
		public AssetInfo GetAssetInfo()
		{
			return null;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x181A5E0", Offset = "0x18199E0", VA = "0x18181A5E0")]
		public DownloadStatus GetDownloadStatus()
		{
			return default(DownloadStatus);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x1700003B")]
		public EOperationStatus Status
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x181A8F0", Offset = "0x1819CF0", VA = "0x18181A8F0")]
			get
			{
				return EOperationStatus.None;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700003C")]
		public string LastError
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x181A840", Offset = "0x1819C40", VA = "0x18181A840")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000191 RID: 401 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x1700003D")]
		public float Progress
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x181A8B0", Offset = "0x1819CB0", VA = "0x18181A8B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x1700003E")]
		public bool IsDone
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x181A6B0", Offset = "0x1819AB0", VA = "0x18181A6B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700003F")]
		public bool IsValid
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x181A820", Offset = "0x1819C20", VA = "0x18181A820")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x17000040")]
		internal bool IsValidWithWarning
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x181A700", Offset = "0x1819B00", VA = "0x18181A700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1808CC0", Offset = "0x18080C0", VA = "0x181808CC0")]
		internal void ReleaseInternal()
		{
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000041")]
		public Task Task
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x181A930", Offset = "0x1819D30", VA = "0x18181A930")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x181A660", Offset = "0x1819A60", VA = "0x18181A660", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x9481A0", Offset = "0x9475A0", VA = "0x1809481A0", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000199 RID: 409 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x17000042")]
		private object Current
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xB9A520", Offset = "0xB99920", VA = "0x180B9A520", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x10")]
		private readonly AssetInfo _assetInfo;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8F9C0", Offset = "0x8EDC0")]
		private ProviderBase <Provider>k__BackingField;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x20")]
		public Action<HandleBase> OnComplete;
	}
}
